using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSortManager00 : GameManager
{
    private float Xinitial = -13.5f, Yinitial = 3f;
    private float XDistance = 3f, YDistance = 4f;
    private int XCards = 10, YCards = 3;
    private float XPos, YPos;
    private int Cardcounter;
    public void SortCards()
    {
        Cardcounter = 0;
        foreach (GameObject group in useCards)
        {
            if (group.activeSelf)
            {
                XPos = Xinitial + Cardcounter % XCards * XDistance;
                YPos = Yinitial - Cardcounter / XCards * YDistance;
                group.transform.position = new Vector3(XPos, YPos, 0);
                Cardcounter += 1;
            }
            if (Cardcounter >= XCards * YCards)
            {
                Cardcounter = 0;
            }
        }
    }
}
