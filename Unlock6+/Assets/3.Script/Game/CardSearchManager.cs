using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardSearchManager : GameManager
{
    [SerializeField] InputField inputCardName;
    [SerializeField] GameObject ErrorMessage, PleaseUIDownMassage, WinMassage;
    [SerializeField] string Keynumber, scenename;
    private bool IsExistenceCaed;
    private string transinput;

    public void CardSearchClick()
    {
        if (cardInformationUI[1].activeSelf)
        {
            StopCoroutine(OnPleaseUIDownMessage());
            StartCoroutine(OnPleaseUIDownMessage());
            return;
        }

        transinput = TranslationResult(inputCardName.text);
        if (transinput == Keynumber)
        {
            StartCoroutine(OnWinMessage());
            return;
        }

        IsExistenceCaed = false;
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
    IEnumerator OnPleaseUIDownMessage()
    {
        PleaseUIDownMassage.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        PleaseUIDownMassage.SetActive(false);
    }
    IEnumerator OnWinMessage()
    {
        WinMassage.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        WinMassage.SetActive(false);
        SceneLoader(scenename);
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

    public void SceneLoader(string Scenename)
    {
        SceneManager.LoadScene(Scenename, LoadSceneMode.Single);
    }
}
