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
    public static int orderInLayer = 60;
    private bool isfront = false;
    private float RotationZ, RotationZRadians;
    private float Xpoint1, Xpoint2, Ypoint1, Ypoint2, point;
    private float width = 0.9f, height = 1.675f;
    private Vector3 Error, points;
    private Camera cam;


    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        GetComponent<SpriteRenderer>().sprite = back;
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
            if (isfront)
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
        SetPosition();
    }

    // 오브젝트 드래그 앤 드롭
    private void OnMouseDown()
    {

        orderInLayer += 1;
        gameObject.GetComponent<Renderer>().sortingOrder = orderInLayer;
        
        //object의 좌표와 커서 좌표의 오차
        Error = transform.position - MousePos();
    }

    private void OnMouseDrag()
    {
        //object의 위치를 오차만큼 더한곳으로 옮기기
        Vector3 pos = MousePos() + Error;
        transform.position = pos;
        SetPosition();
    }

    private Vector3 MousePos()
    {
        // 커서의 월드 좌표값 가져오기
        Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos; // 마우스 위치값 반환 
    }

    private void SetPosition()
    {
        RotationZ = transform.rotation.eulerAngles.z;
        RotationZRadians = RotationZ * Mathf.Deg2Rad;
        Xpoint1 = width * Mathf.Cos(RotationZRadians) - height * Mathf.Sin(RotationZRadians);
        Ypoint1 = width * Mathf.Sin(RotationZRadians) + height * Mathf.Cos(RotationZRadians);
        Xpoint2 = width * Mathf.Cos(RotationZRadians) + height * Mathf.Sin(RotationZRadians);
        Ypoint2 = - width * Mathf.Sin(RotationZRadians) + height * Mathf.Cos(RotationZRadians);
        SetXposition(Xpoint1);
        SetXposition(Xpoint2);
        SetXposition(-Xpoint1);
        SetXposition(-Xpoint2);
        SetYposition(Ypoint1);
        SetYposition(Ypoint2);
        SetYposition(-Ypoint1);
        SetYposition(-Ypoint2);
    }

    private void SetXposition(float Xpoint)
    {
        points = transform.position;
        point = transform.position.x;
        if (point + Xpoint > maxX)
        {
            point = maxX - Xpoint;
        }
        if ( point - Xpoint < minX)
        {
            point = minX + Xpoint;
        }
        points.x = point;
        transform.position = points;
    }

    private void SetYposition(float Ypoint)
    {
        points = transform.position;
        point = transform.position.y;
        if (point + Ypoint > maxY)
        {
            point = maxY - Ypoint;
        }
        if (point - Ypoint < minY)
        {
            point = minY + Ypoint;
        }
        points.y = point;
        transform.position = points;
    }

}
