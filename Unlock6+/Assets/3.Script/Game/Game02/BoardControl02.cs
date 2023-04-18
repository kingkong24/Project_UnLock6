using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardControl02 : GameManager
{
    [SerializeField] public Sprite front0, back0;
    public Sprite front, back;
    public bool isfront = true;
    private float curlSpeed = 20;

    void Awake()
    {
        gameObject.SetActive(false);
        front = front0;
        back = back0;
        GetComponent<SpriteRenderer>().sprite = front;
        transform.position = new Vector3(-9f, 0, 0);
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
            if (isfront)
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

    public void ActiveBoard()
    {
        gameObject.SetActive(true);
    }
}
