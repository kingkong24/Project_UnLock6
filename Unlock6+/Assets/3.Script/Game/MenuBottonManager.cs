using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBottonManager : GameManager
{
    [SerializeField] public GameObject[] MenuUI;

    public void CardSearchClick()
    {
        ObjectsArrayOnOff(true, MenuUI);
    }
}
