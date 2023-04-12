using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConrtol : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f; // ������ �ӵ�
    [SerializeField] public float zoomSpeed = 5f; // �� �ӵ�

    [SerializeField] private float limitX = 19f, limitY = 10f; // ������ ����
    [SerializeField] private float minSize = 2.5f, maxSize = 8.5f; // �� ����

    private Camera cam;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        // WASD�� ī�޶� �̵�
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal * moveSpeed * Time.deltaTime, vertical * moveSpeed * Time.deltaTime, 0);
        // transform.position = new Vector3(transform.position.x, transform.position.y, -10);

        // ���콺 �ٷ� ī�޶� �� ��/�ƿ�
        float zoom = Input.GetAxis("Mouse ScrollWheel");
        cam.orthographicSize -= zoom * zoomSpeed;

        // ī�޶� ��ġ ����
        Vector3 pos = transform.position;
        float camSizeX = cam.orthographicSize * cam.aspect;
        float camSizeY = cam.orthographicSize;
        float maxX = limitX - camSizeX;
        float maxY = limitY - camSizeY;

        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        pos.y = Mathf.Clamp(pos.y, -maxY, maxY);

        transform.position = pos;

        // ī�޶��� ũ�⸦ ����
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minSize, maxSize);
    }
}

