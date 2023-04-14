using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSearchManager00 : GameManager
{
    [SerializeField] InputField inputCardName;
    [SerializeField] GameObject ErrorMessage;
    private bool IsExistenceCaed;

    public void CardSearchClick()
    {
        IsExistenceCaed = false;
        foreach (GameObject group in informationCards)
        {
            if (group.name == inputCardName.text)
            {
                curCard = inputCardName.text;
                ObjectsArrayOnOff(true, cardInformationUI);
                ObjectinArrayOnOff(true, informationCards, curCard);
                IsExistenceCaed = true;
            }
        }
        if (!IsExistenceCaed)
        {
            StopCoroutine(OnErrorMessage());
            StartCoroutine(OnErrorMessage());
        }
    }

    IEnumerator OnErrorMessage()
    {
        ErrorMessage.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        ErrorMessage.SetActive(false);

    }
}
