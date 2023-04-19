using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardControl : MonoBehaviour
{
    [SerializeField] private float minX = -14, maxX = 14, minY = -6, maxY = 4;
    [SerializeField] private float curlSpeed = 20f;
    [SerializeField] public Sprite front, back;
    [SerializeField] private AudioClip cardReverseSound;
    private AudioSource audioSource;
    public static int orderInLayer = 0;
    private bool isfront = false;
    private float RotationZ;
    private Vector3 Error;
    private Camera cam;


    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        GetComponent<SpriteRenderer>().sprite = back;
        gameObject.GetComponent<Renderer>().sortingOrder = orderInLayer;
        cam = Camera.main;
    }

    private void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            RotationZ = transform.rotation.eulerAngles.z + curlSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, RotationZ);
        }

        if (Input.GetKey(KeyCode.E))
        {
            RotationZ = transform.rotation.eulerAngles.z - curlSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, RotationZ);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(isfront)
            {
                audioSource.PlayOneShot(cardReverseSound);
                GetComponent<SpriteRenderer>().sprite = back;
                isfront = false;
            }
            else
            {
                audioSource.PlayOneShot(cardReverseSound);
                GetComponent<SpriteRenderer>().sprite = front;
                isfront = true;
            }
        }
    }

    // ������Ʈ �巡�� �� ���
    private void OnMouseDown()
    {
        orderInLayer += 1;
        gameObject.GetComponent<Renderer>().sortingOrder = orderInLayer;
        
        //object�� ��ǥ�� Ŀ�� ��ǥ�� ����
        Error = transform.position - MousePos();
    }

    private void OnMouseDrag()
    {
        float radian = Mathf.Deg2Rad * 30f;
        float sinValue = Mathf.Sin(radian);
        float cosValue = Mathf.Cos(radian);

        //object�� ��ġ�� ������ŭ ���Ѱ����� �ű��
        Vector3 pos = MousePos() + Error;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }

    private Vector3 MousePos()
    {
        // Ŀ���� ���� ��ǥ�� ��������
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos; // ���콺 ��ġ�� ��ȯ 
    }
}
