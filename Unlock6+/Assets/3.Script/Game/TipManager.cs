using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipManager : MonoBehaviour
{
    [SerializeField] GameObject[] tips;
    private int tipNum;
    WaitForSeconds WaitTime1 = new WaitForSeconds(12.5f);
    WaitForSeconds WaitTime2 = new WaitForSeconds(12.5f);

    private void Start()
    {
        tipNum = 0;
        StartCoroutine(OnTipMessage());
    }

    IEnumerator OnTipMessage()
    {
        while (true)
        {
            yield return WaitTime1;
            tips[tipNum].SetActive(true);
            yield return WaitTime2;
            tips[tipNum].SetActive(false);
            tipNum += 1;
            if(tipNum >=8)
            {
                tipNum = 0;
            }
            yield return WaitTime1;
        }
    }
}
