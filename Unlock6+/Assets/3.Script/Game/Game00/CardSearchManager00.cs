using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSearchManager00 : GameManager
{
    [SerializeField] InputField inputCardName;
    [SerializeField] GameObject ErrorMessage;
    private bool IsExistenceCaed;
    private string transinput;

    public void CardSearchClick()
    {
        if (cardInformationUI[1].activeSelf)
        {
            return;
        }

        IsExistenceCaed = false;
        transinput = TranslationResult(inputCardName.text);
        foreach (GameObject group in informationCards)
        {
            if (group.name == transinput)
            {
                curCard = transinput;
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

    // string ���� �ҹ��ڸ� �빮�ڷ� �ٲ��ְų�, ���ڸ� ���� �տ� 0�� ���ΰ�� ���ִ� �޼ҵ�
    private string TranslationResult(string input)
    {
        if (input.StartsWith("0") && input.Length > 1)
        {
            return input.Substring(1);
        }
        return input.ToUpper();
    }
}
