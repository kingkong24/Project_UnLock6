using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConrtol : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f; // 움직임 속도
    [SerializeField] public float zoomSpeed = 5f; // 줌 속도

    [SerializeField] private float limitX = 19f, limitY = 10f; // 움직임 제한
    [SerializeField] private float minSize = 2.5f, maxSize = 8.5f; // 줌 제한

    private Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        // WASD로 카메라 이동
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal * moveSpeed * Time.deltaTime, vertical * moveSpeed * Time.deltaTime, 0);
        // transform.position = new Vector3(transform.position.x, transform.position.y, -10);

        // 마우스 휠로 카메라 줌 인/아웃
        float zoom = Input.GetAxis("Mouse ScrollWheel");
        cam.orthographicSize -= zoom * zoomSpeed;

        // 카메라 위치 제한
        Vector3 pos = transform.position;
        float camSizeX = cam.orthographicSize * cam.aspect;
        float camSizeY = cam.orthographicSize;
        float maxX = limitX - camSizeX;
        float maxY = limitY - camSizeY;

        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        pos.y = Mathf.Clamp(pos.y, -maxY, maxY);

        transform.position = pos;

        // 카메라의 크기를 제한
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minSize, maxSize);
    }
}

