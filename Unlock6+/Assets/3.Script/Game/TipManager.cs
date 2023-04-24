using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipManager : MonoBehaviour
{
    [SerializeField] GameObject[] tips;
    private int tipNum;

    private void Start()
    {
        tipNum = 0;
        StartCoroutine(OnTipMessage());
    }

    IEnumerator OnTipMessage()
    {
        while (true)
        {
            yield return new WaitForSeconds(12.5f);
            tips[tipNum].SetActive(true);
            yield return new WaitForSeconds(5.0f);
            tips[tipNum].SetActive(false);
            tipNum += 1;
            if(tipNum >=7)
            {
                tipNum = 0;
            }
            yield return new WaitForSeconds(12.5f);
        }
    }
}
