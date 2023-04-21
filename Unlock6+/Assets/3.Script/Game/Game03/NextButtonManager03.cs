using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class NextButtonManager03 : GameManager
{
    [SerializeField] public GameObject GameObjectboard;
    public bool isfront = true;
    private List<string> targetCard;

    // "다음으로" 버튼 관련 메소드
    public void NextButtonClick()
    {
        MethodInfo methodInfo = GetType().GetMethod("Gimmick" + curCard);

        // 함수 이름과 일치하는 메소드가 있는지 확인
        if (methodInfo != null)
        {
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
        BringCard("0");
        cardQueue.Enqueue("0_1");
    }
    public void Gimmick0_1()
    {
        GameObjectboard.SetActive(true);
        targetCard = new List<string> { "35", "58", "72" };
        BringCards(targetCard);
    }
    public void Gimmick35()
    {
        BringCard("35");
        cardQueue.Enqueue("35_1");
    }
    public void Gimmick58()
    {
        BringCard("58");
        cardQueue.Enqueue("58_1");
    }
    public void Gimmick72()
    {
        BringCard("72");
        cardQueue.Enqueue("72_1");
    }
    public void Gimmick17()
    {
        BringCard("17");
        cardQueue.Enqueue("17_1");
    }
    public void Gimmick17_1()
    {
        targetCard = new List<string> { "21", "79" };
        BringCards(targetCard);
    }
    public void Gimmick21()
    {
        BringCard("21");
        cardQueue.Enqueue("21_1");
    }
    public void Gimmick79()
    {
        BringCard("79");
        cardQueue.Enqueue("79_1");
    }
    public void Gimmick79_1()
    {
        cardQueue.Enqueue("1");
    }
    public void Gimmick1()
    {
        BringCard("1");
        cardQueue.Enqueue("1_1");
    }
    public void Gimmick71()
    {
        BringCard("71");
        cardQueue.Enqueue("71_1");
    }
    public void Gimmick71_1()
    {
        ObjectinArrayOnOff(false, useCards, "21");
        ObjectinArrayOnOff(false, useCards, "58");
    }
    public void Gimmick11()
    {
        BringCard("11");
        cardQueue.Enqueue("11_1");
    }
    public void Gimmick11_1()
    {
        cardQueue.Enqueue("36");
        ObjectinArrayOnOff(false, useCards, "1");
    }
    public void Gimmick36()
    {
        BringCard("36");
        cardQueue.Enqueue("36_1");
    }
    public void Gimmick36_1()
    {
        targetCard = new List<string> { "18", "33", "G" };
        BringCards(targetCard);
    }
    public void Gimmick18()
    {
        BringCard("18");
        cardQueue.Enqueue("18_1");
    }
    public void Gimmick33()
    {
        BringCard("33");
        cardQueue.Enqueue("33_1");
    }
    public void GimmickG()
    {
        BringCard("G");
        cardQueue.Enqueue("G_1");
    }
    public void GimmickG_1()
    {
        targetCard = new List<string> { "13", "14", "26", "54", "82" };
        BringCards(targetCard);
    }
    public void Gimmick13()
    {
        BringCard("13");
        cardQueue.Enqueue("13_1");
    }
    public void Gimmick14()
    {
        BringCard("14");
        cardQueue.Enqueue("14_1");
    }
    public void Gimmick26()
    {
        BringCard("26");
        cardQueue.Enqueue("26_1");
    }
    public void Gimmick54()
    {
        BringCard("54");
        cardQueue.Enqueue("54_1");
    }
    public void Gimmick82()
    {
        BringCard("82");
        cardQueue.Enqueue("82_1");
    }
    public void Gimmick95()
    {
        BringCard("95");
        cardQueue.Enqueue("95_1");
    }
    public void Gimmick95_1()
    {
        targetCard = new List<string> { "55", "70" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "11");
        ObjectinArrayOnOff(false, useCards, "13");
        ObjectinArrayOnOff(false, useCards, "82");
    }
    public void Gimmick55()
    {
        BringCard("55");
        cardQueue.Enqueue("55_1");
    }
    public void Gimmick70()
    {
        BringCard("70");
        cardQueue.Enqueue("70_1");
    }
    public void Gimmick68()
    {
        BringCard("68");
        cardQueue.Enqueue("68_1");
    }
    public void Gimmick68_1()
    {
        ObjectinArrayOnOff(false, useCards, "14");
        ObjectinArrayOnOff(false, useCards, "54");
    }
    public void Gimmick24()
    {
        BringCard("24");
        cardQueue.Enqueue("24_1");
    }
    public void Gimmick24_1()
    {
        targetCard = new List<string> { "43", "69" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "55");
    }
    public void Gimmick43()
    {
        BringCard("43");
        cardQueue.Enqueue("43_1");
    }
    public void Gimmick69()
    {
        BringCard("69");
        cardQueue.Enqueue("69_1");
    }
    public void Gimmick97()
    {
        BringCard("97");
        cardQueue.Enqueue("97_1");
    }
    public void GimmickY()
    {
        BringCard("Y");
        cardQueue.Enqueue("Y_1");
    }
    public void GimmickY_1()
    {
        targetCard = new List<string> { "40", "52" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "17");
        ObjectinArrayOnOff(false, useCards, "18");
        ObjectinArrayOnOff(false, useCards, "33");
        ObjectinArrayOnOff(false, useCards, "79");
    }
    public void Gimmick40()
    {
        BringCard("40");
        cardQueue.Enqueue("40_1");
    }
    public void Gimmick52()
    {
        BringCard("52");
        cardQueue.Enqueue("52_1");
    }
    public void Gimmick74()
    {
        BringCard("74");
        cardQueue.Enqueue("74_1");
    }
    public void Gimmick74_1()
    {
        targetCard = new List<string> { "30", "46", "X" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "40");
        ObjectinArrayOnOff(false, useCards, "69");
    }
    public void Gimmick30()
    {
        BringCard("30");
        cardQueue.Enqueue("30_1");
    }
    public void Gimmick46()
    {
        BringCard("46");
        cardQueue.Enqueue("46_1");
    }
    public void Gimmick46_1()
    {
        ObjectinArrayOnOff(false, useCards, "40");
        ObjectinArrayOnOff(false, useCards, "69");
        cardQueue.Enqueue("9");
    }
    public void GimmickX()
    {
        BringCard("X");
        cardQueue.Enqueue("X_1");
    }

    public void Gimmick9()
    {
        BringCard("9");
        cardQueue.Enqueue("9_1");
    }
    public void Gimmick77()
    {
        BringCard("77");
        cardQueue.Enqueue("77_1");
    }
    public void Gimmick77_1()
    {
        cardQueue.Enqueue("19");
        ObjectinArrayOnOff(false, useCards, "9");
        ObjectinArrayOnOff(false, useCards, "43");
        ObjectinArrayOnOff(false, useCards, "68");
    }
    public void Gimmick19()
    {
        BringCard("19");
        cardQueue.Enqueue("19_1");
    }
    public void Gimmick28()
    {
        BringCard("28");
        cardQueue.Enqueue("28_1");
    }
    public void Gimmick45()
    {
        BringCard("45");
        cardQueue.Enqueue("45_1");
    }
    public void Gimmick45_1()
    {
        ObjectinArrayOnOff(false, useCards, "26");
    }
    public void Gimmick2()
    {
        BringCard("2");
        cardQueue.Enqueue("2_1");
    }
    public void Gimmick5()
    {
        BringCard("5");
        cardQueue.Enqueue("5_1");
    }
    public void Gimmick7()
    {
        BringCard("7");
        cardQueue.Enqueue("7_1");
    }
    public void Gimmick7_1()
    {
        targetCard = new List<string> { "10", "23" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "28");
        ObjectinArrayOnOff(false, useCards, "45");
        ObjectinArrayOnOff(false, useCards, "46");
        ObjectinArrayOnOff(false, useCards, "X");
        ObjectinArrayOnOff(false, useCards, "2");
        ObjectinArrayOnOff(false, useCards, "5");
    }
    public void Gimmick10()
    {
        BringCard("10");
        cardQueue.Enqueue("10_1");
    }
    public void Gimmick23()
    {
        BringCard("23");
        cardQueue.Enqueue("23_1");
    }
    public void Gimmick29()
    {
        BringCard("29");
        cardQueue.Enqueue("29_1");
    }
    public void Gimmick29_1()
    {
        ObjectinArrayOnOff(false, useCards, "19");
    }
    public void Gimmick64()
    {
        BringCard("64");
        cardQueue.Enqueue("64_1");
    }
    public void Gimmick64_1()
    {
        ObjectinArrayOnOff(false, useCards, "29");
        ObjectinArrayOnOff(false, useCards, "35");
    }
    public void Gimmick12()
    {
        BringCard("12");
        cardQueue.Enqueue("12_1");
    }
    public void Gimmick22()
    {
        BringCard("22");
        cardQueue.Enqueue("22_1");
    }
    public void Gimmick22_1()
    {
        ObjectinArrayOnOff(false, useCards, "12");
    }
    public void Gimmick86()
    {
        BringCard("86");
        cardQueue.Enqueue("86_1");
    }
    public void Gimmick86_1()
    {
        ObjectinArrayOnOff(false, useCards, "10");
        ObjectinArrayOnOff(false, useCards, "22");
        ObjectinArrayOnOff(false, useCards, "64");
    }
    public void Gimmick75()
    {
        BringCard("75");
        cardQueue.Enqueue("75_1");
    }
    public void Gimmick75_1()
    {
        ObjectinArrayOnOff(false, useCards, "23");
        ObjectinArrayOnOff(false, useCards, "52");
        ObjectinArrayOnOff(false, useCards, "Y");
    }
    public void Gimmick83()
    {
        BringCard("83");
        cardQueue.Enqueue("83_1");
    }
    public void Gimmick83_1()
    {
        targetCard = new List<string> { "37", "B" };
        BringCards(targetCard);
    }
    public void Gimmick37()
    {
        BringCard("37");
        cardQueue.Enqueue("37_1");
    }
    public void GimmickB()
    {
        BringCard("B");
        cardQueue.Enqueue("B_1");
    }
    public void Gimmick67()
    {
        BringCard("67");
        cardQueue.Enqueue("67_1");
    }
    public void Gimmick67_1()
    {
        cardQueue.Enqueue("20");
        ObjectinArrayOnOff(false, useCards, "30");
        ObjectinArrayOnOff(false, useCards, "37");
        ObjectinArrayOnOff(false, useCards, "72");
        ObjectinArrayOnOff(false, useCards, "83");
        ObjectinArrayOnOff(false, useCards, "B");
    }
    public void Gimmick20()
    {
        BringCard("20");
        cardQueue.Enqueue("20_1");
    }
    public void Gimmick16()
    {
        BringCard("16");
        cardQueue.Enqueue("16_1");
    }
    public void Gimmick16_1()
    {
        ObjectinArrayOnOff(false, useCards, "20");
        ObjectinArrayOnOff(false, useCards, "70");
        ObjectinArrayOnOff(false, useCards, "86");
        ObjectinArrayOnOff(false, useCards, "95");
    }
    public void Gimmick99()
    {
        BringCard("99");
        cardQueue.Enqueue("99_1");
    }
    // 벌점카드
    public void GimmickH()
    {
        BringCard("H");
        cardQueue.Enqueue("H_1");
    }
    public void GimmickH_1()
    {
        ObjectinArrayOnOff(false, useCards, "H");
    }
    public void GimmickV()
    {
        BringCard("V");
        cardQueue.Enqueue("V_1");
    }
    public void GimmickV_1()
    {
        ObjectinArrayOnOff(false, useCards, "V");
    }
    public void GimmickQ()
    {
        BringCard("Q");
        cardQueue.Enqueue("Q_1");
    }
    public void GimmickQ_1()
    {
        ObjectinArrayOnOff(false, useCards, "Q");
    }
    #endregion
    // 카드를 활성화하고 자리 설정
    public void BringCard(string curCard)
    {
        if (!IsRun[curCard])
        {
            ObjectinArrayOnOff(true, useCards, curCard);
            ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, curCard);
            IsRun[curCard] = true;
        }
    }

    // 카드들을 활성화하고 자리 설정
    public void BringCards(List<string> targetCard)
    {
        foreach (string group in targetCard)
        {
            if (IsRun.ContainsKey(group) && !IsRun[group])
            {
                BringCard(group);
                cardQueue.Enqueue(group);
            }
        }
    }
}
