using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardControl : MonoBehaviour
{
    [SerializeField] private float minX = -16, maxX = 16, minY = -9, maxY = 7;
    [SerializeField] private float curlSpeed = 20f;
    [SerializeField] public Sprite front, back;
    private bool isfront = false;
    private Vector3 Error;
    private Camera cam;


    void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = back;
        cam = Camera.main;
    }

    private void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + curlSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z - curlSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if(isfront)
            {
                GetComponent<SpriteRenderer>().sprite = back;
                isfront = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = front;
                isfront = true;
            }
        }
    }

    // ������Ʈ �巡�� �� ���
    private void OnMouseDown()
    {
        //object�� ��ǥ�� Ŀ�� ��ǥ�� ����
        Error = transform.position - MousePos();
    }

    private void OnMouseDrag()
    {
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
