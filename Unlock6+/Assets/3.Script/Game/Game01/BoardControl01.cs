using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardControl01 : GameManager
{
    [SerializeField] public Sprite front0, back0;
    public Sprite front, back;
    public bool isfront = true;

    void Awake()
    {
        gameObject.SetActive(false);
        front = front0;
        back = back0;
        GetComponent<SpriteRenderer>().sprite = front;
        transform.position = new Vector3(-9, 2, 0);
    }

    private void OnMouseOver()
    {
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
