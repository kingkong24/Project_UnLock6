using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardControl01 : GameManager
{
    [SerializeField] public Sprite front0, back0;
    [SerializeField] private AudioClip cardReverseSound;
    private AudioSource audioSource;
    public Sprite front, back;
    public bool isfront = true;

    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
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

    public void ActiveBoard()
    {
        gameObject.SetActive(true);
    }
}
