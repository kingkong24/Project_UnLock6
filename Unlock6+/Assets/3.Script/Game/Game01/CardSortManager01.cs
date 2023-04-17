using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSortManager01 : GameManager
{
    private Vector3[] cardPos = new Vector3[]
    {
        new Vector3(0, 4, 0), new Vector3(3, 4, 0), new Vector3(6, 4, 0), new Vector3(9, 4, 0), new Vector3(12, 4, 0),
        new Vector3(3, 0, 0), new Vector3(6, 0, 0), new Vector3(9, 0, 0), new Vector3(12, 0, 0),
        new Vector3(-12, -4, 0), new Vector3(-9, -4, 0), new Vector3(-6, -4, 0), new Vector3(-3, -4, 0), new Vector3(0, -4, 0),
        new Vector3(3, -4, 0), new Vector3(6, -4, 0), new Vector3(9, -4, 0), new Vector3(12, -4, 0)
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
