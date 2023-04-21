using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSortManager03 : GameManager
{
    [SerializeField] AudioSource AudioSource;
    [SerializeField] AudioClip CardSortAudio;
    private Vector3[] cardPos = new Vector3[]
    {
        new Vector3(1, 4, 0), new Vector3(4, 4, 0), new Vector3(7, 4, 0), new Vector3(10, 4, 0), new Vector3(13, 4, 0),
        new Vector3(1, 0, 0), new Vector3(4, 0, 0), new Vector3(7, 0, 0), new Vector3(10, 0, 0), new Vector3(13, 0, 0),
        new Vector3(1, -4, 0), new Vector3(4, -4, 0), new Vector3(7, -4, 0), new Vector3(10, -4, 0), new Vector3(13, -4, 0),
    };
    private int CardNum = 15;
    private int Cardcounter;

    public void SortCards()
    {
        AudioSource.PlayOneShot(CardSortAudio);
        Cardcounter = 0;
        foreach (GameObject group in useCards)
        {
            if (group.activeSelf)
            {
                group.transform.position = cardPos[Cardcounter];
                Cardcounter += 1;
            }
            if (Cardcounter >= CardNum)
            {
                Cardcounter = 0;
            }
        }
    }
}
