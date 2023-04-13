using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Reflection;

public class NextButtonManager00 : GameManager
{
    private List<string> targetCard;

    // "다음으로" 버튼 관련 메소드
    public void NextButtonClick()
    {
        MethodInfo methodInfo = GetType().GetMethod("Gimmick" + curCard);

        // 함수 이름과 일치하는 메소드가 있는지 확인
        if (methodInfo == null)
        {
            Debug.Log("Function not found : Gimmick" + curCard);
        }
        else
        {
            // 함수 호출
            methodInfo.Invoke(this, null);
        }

        // 다음 카드를 인터페이스에 출력
        ObjectinArrayOnOff(false, informationCards, curCard);
        if (cardQueue.Count == 0)
        {
            ObjectsArrayOnOff(false, cardInformationUI);
        }
        else
        {
            curCard = cardQueue.Dequeue();
            ObjectinArrayOnOff(true, informationCards, curCard);
        }
    }

    #region
    public void Gimmick0()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "0");
        cardQueue.Enqueue("0_1");
    }
    public void Gimmick0_1()
    {
        targetCard = new List<string> { "11", "11_1", "21", "21_1", "35", "35_1", "42", "42_1", "69", "69_1" };
       
        foreach (string group in targetCard)
        {
            ObjectinArrayPosition(new Vector3 (0, 0, 0), useCards, group);
            cardQueue.Enqueue(group);
        }
    }
    public void Gimmick46()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "46");
        cardQueue.Enqueue("46_1");
    }
    public void Gimmick46_1()
    {
        ObjectinArrayOnOff(false, useCards, "11");
        ObjectinArrayOnOff(false, useCards, "35");
    }
    public void Gimmick16()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "16");
        cardQueue.Enqueue("16_1");
    }
    public void Gimmick25()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "25");
        cardQueue.Enqueue("25_1");
    }
    public void Gimmick25_1()
    {
        ObjectinArrayOnOff(false, useCards, "16");
        ObjectinArrayOnOff(false, useCards, "46");
        ObjectinArrayOnOff(false, useCards, "69");
    }
    public void Gimmick48()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "48");
        cardQueue.Enqueue("48_1");
    }
    public void Gimmick48_1()
    {
        ObjectinArrayOnOff(false, useCards, "25");
        ObjectinArrayOnOff(false, useCards, "42");
    }

    #endregion
}
