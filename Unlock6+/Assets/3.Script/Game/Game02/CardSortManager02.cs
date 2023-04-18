using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSortManager02 : GameManager
{
    private Vector3[] cardPos = new Vector3[]
    {
        new Vector3(-1, 4, 0), new Vector3(2, 4, 0), new Vector3(5, 4, 0), new Vector3(8, 4, 0), new Vector3(11, 4, 0), new Vector3(14, 4, 0),
        new Vector3(-1, 0, 0), new Vector3(2, 0, 0), new Vector3(5, 0, 0), new Vector3(8, 0, 0), new Vector3(11, 0, 0), new Vector3(14, 0, 0),
        new Vector3(-1, -4, 0), new Vector3(2, -4, 0), new Vector3(5, -4, 0), new Vector3(8, -4, 0), new Vector3(11, -4, 0), new Vector3(14, -4, 0)
    };
    private int CardNum = 18;
    private int Cardcounter;

    public void SortCards()
    {
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
