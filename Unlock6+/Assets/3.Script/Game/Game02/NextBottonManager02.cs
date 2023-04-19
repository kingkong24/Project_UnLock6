using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

public class NextBottonManager02 : GameManager
{
    [SerializeField] public GameObject GameObjectboard;
    public bool isfront = true;
    private List<string> targetCard;

    void OnEnable()
    {
        GameObject boardObject = GameObject.Find("Board0");
    }

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
        targetCard = new List<string> { "9", "20" };
        BringCards(targetCard);
    }
    public void Gimmick9()
    {
        BringCard("9");
        cardQueue.Enqueue("9_1");
    }
    public void Gimmick20()
    {
        BringCard("20");
        cardQueue.Enqueue("20_1");
    }
    public void GimmickD()
    {
        BringCard("D");
        cardQueue.Enqueue("D_1");
    }
    public void GimmickD_1()
    {
        targetCard = new List<string> { "18", "75"};
        BringCards(targetCard);
    }
    public void Gimmick18()
    {
        BringCard("18");
        cardQueue.Enqueue("18_1");
    }
    public void Gimmick75()
    {
        BringCard("75");
        cardQueue.Enqueue("75_1");
    }
    public void GimmickM()
    {
        BringCard("M");
        cardQueue.Enqueue("M_1");
    }
    public void GimmickM_1()
    {
        targetCard = new List<string> { "35", "86", "87", "88", "89" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "18");
        ObjectinArrayOnOff(false, useCards, "75");
    }
    public void Gimmick35()
    {
        BringCard("35");
        cardQueue.Enqueue("35_1");
    }
    public void Gimmick86()
    {
        BringCard("86");
        cardQueue.Enqueue("86_1");
    }
    public void Gimmick87()
    {
        BringCard("87");
        cardQueue.Enqueue("87_1");
    }
    public void Gimmick88()
    {
        BringCard("88");
        cardQueue.Enqueue("88_1");
    }
    public void Gimmick89()
    {
        BringCard("89");
        cardQueue.Enqueue("89_1");
    }
    public void Gimmick55()
    {
        BringCard("55");
        cardQueue.Enqueue("55_1");
    }
    public void Gimmick55_1()
    {
        targetCard = new List<string> { "81", "83", "84" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "20");
        ObjectinArrayOnOff(false, useCards, "35");
    }
    public void Gimmick81()
    {
        BringCard("81");
        cardQueue.Enqueue("81_1");
    }
    public void Gimmick83()
    {
        BringCard("83");
        cardQueue.Enqueue("83_1");
    }
    public void Gimmick84()
    {
        BringCard("84");
        cardQueue.Enqueue("84_1");
    }
    public void Gimmick84_1()
    {
        ObjectinArrayOnOff(false, useCards, "55");
    }
    public void GimmickN()
    {
        BringCard("N");
        cardQueue.Enqueue("N_1");
    }
    public void GimmickN_1()
    {
        cardQueue.Enqueue("43");
        ObjectinArrayOnOff(false, useCards, "86");
        ObjectinArrayOnOff(false, useCards, "87");
        ObjectinArrayOnOff(false, useCards, "88");
        ObjectinArrayOnOff(false, useCards, "89");
    }
    public void Gimmick43()
    {
        BringCard("43");
        cardQueue.Enqueue("43_1");
    }
    public void Gimmick31()
    {
        BringCard("31");
        cardQueue.Enqueue("31_1");
    }
    public void Gimmick1()
    {
        BringCard("1");
        cardQueue.Enqueue("1_1");
    }
    public void GimmickX()
    {
        BringCard("X");
        cardQueue.Enqueue("X_1");
    }
    public void Gimmick23()
    {
        BringCard("23");
        cardQueue.Enqueue("23_1");
    }
    public void Gimmick23_1()
    {
        ObjectinArrayOnOff(false, useCards, "31");
        ObjectinArrayOnOff(false, useCards, "43");
    }
    public void Gimmick50()
    {
        BringCard("50");
        cardQueue.Enqueue("50_1");
    }
    public void Gimmick50_1()
    {
        ObjectinArrayOnOff(false, useCards, "1");
    }
    public void Gimmick59()
    {
        BringCard("59");
        cardQueue.Enqueue("59_1");
    }
    public void Gimmick59_1()
    {
        ObjectinArrayOnOff(false, useCards, "9");
        ObjectinArrayOnOff(false, useCards, "50");
        ObjectinArrayOnOff(false, useCards, "59");
    }
    public void GimmickP()
    {
        BringCard("P");
        cardQueue.Enqueue("P_1");
    }
    public void GimmickP_1()
    {
        ObjectinArrayOnOff(false, useCards, "23");
    }
    public void Gimmick92()
    {
        BringCard("92");
        cardQueue.Enqueue("92_1");
    }
    public void Gimmick92_1()
    {
        cardQueue.Enqueue("95");
        ObjectinArrayOnOff(false, useCards, "P");
    }
    public void Gimmick95()
    {
        BringCard("95");
        cardQueue.Enqueue("95_1");
    }
    public void GimmickH()
    {
        BringCard("H");
        cardQueue.Enqueue("H_1");
    }
    public void Gimmick4()
    {
        BringCard("4");
        cardQueue.Enqueue("4_1");
    }
    public void Gimmick99()
    {
        BringCard("99");
        cardQueue.Enqueue("99_1");
    }
    public void Gimmick99_1()
    {
        targetCard = new List<string> { "67", "15"};
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "92");
        ObjectinArrayOnOff(false, useCards, "95");
        ObjectinArrayOnOff(false, useCards, "X");
        ObjectinArrayOnOff(false, useCards, "4");
    }
    public void Gimmick15()
    {
        BringCard("15");
        cardQueue.Enqueue("15_1");
    }
    public void Gimmick67()
    {
        BringCard("67");
        cardQueue.Enqueue("67_1");
    }
    public void GimmickQ()
    {
        BringCard("Q");
        cardQueue.Enqueue("Q_1");
    }
    public void GimmickQ_1()
    {
        ObjectinArrayOnOff(false, useCards, "15");
    }
    public void Gimmick39()
    {
        BringCard("39");
        cardQueue.Enqueue("39_1");
    }
    public void Gimmick39_1()
    {
        targetCard = new List<string> { "26", "71" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "67");
    }
    public void Gimmick26()
    {
        BringCard("26");
        cardQueue.Enqueue("26_1");
    }
    public void Gimmick71()
    {
        BringCard("71");
        cardQueue.Enqueue("71_1");
    }
    public void GimmickS()
    {
        BringCard("S");
        cardQueue.Enqueue("S_1");
    }
    public void Gimmick90()
    {
        BringCard("90");
        cardQueue.Enqueue("90_1");
    }
    public void Gimmick90_1()
    {
        cardQueue.Enqueue("34");
        ObjectinArrayOnOff(false, useCards, "71");
        ObjectinArrayOnOff(false, useCards, "Q");
    }
    public void Gimmick34()
    {
        BringCard("34");
        cardQueue.Enqueue("34_1");
    }
    public void Gimmick25()
    {
        BringCard("25");
        cardQueue.Enqueue("25_1");
    }
    public void Gimmick25_1()
    {
        ObjectinArrayOnOff(false, useCards, "34");
        ObjectinArrayOnOff(false, useCards, "90");
    }
    public void GimmickT()
    {
        BringCard("T");
        cardQueue.Enqueue("T_1");
    }
    public void Gimmick53()
    {
        BringCard("53");
        cardQueue.Enqueue("53_1");
    }
    public void Gimmick53_1()
    {
        targetCard = new List<string> { "Z", "29" };
        BringCards(targetCard);
        ObjectinArrayOnOff(false, useCards, "25");
    }

    public void GimmickZ()
    {
        BringCard("Z");
        cardQueue.Enqueue("Z_1");
    }
    public void GimmickZ_1()
    {
        cardQueue.Enqueue("12");
    }
    public void Gimmick29()
    {
        BringCard("29");
        cardQueue.Enqueue("29_1");
    }
    public void Gimmick12()
    {
        BringCard("12");
        cardQueue.Enqueue("12_1");
    }
    public void GimmickJ()
    {
        BringCard("J");
        cardQueue.Enqueue("J_1");
    }
    public void GimmickJ_1()
    {
        cardQueue.Enqueue("6");
        ObjectinArrayOnOff(false, useCards, "29");
        ObjectinArrayOnOff(false, useCards, "53");
    }
    public void Gimmick6()
    {
        BringCard("6");
        cardQueue.Enqueue("6_1");
    }
    public void Gimmick52()
    {
        BringCard("52");
        cardQueue.Enqueue("52_1");
    }
    public void Gimmick52_1()
    {
        ObjectinArrayOnOff(false, useCards, "0");
        ObjectinArrayOnOff(false, useCards, "6");
        ObjectinArrayOnOff(false, useCards, "12");
        ObjectinArrayOnOff(false, useCards, "39");
        ObjectinArrayOnOff(false, useCards, "81");
        ObjectinArrayOnOff(false, useCards, "83");
        ObjectinArrayOnOff(false, useCards, "84");
        ObjectinArrayOnOff(false, useCards, "99");
        ObjectinArrayOnOff(false, useCards, "D");
        ObjectinArrayOnOff(false, useCards, "M");
        ObjectinArrayOnOff(false, useCards, "N");
        ObjectinArrayOnOff(false, useCards, "S");
        ObjectinArrayOnOff(false, useCards, "T");
        ObjectinArrayOnOff(false, useCards, "J");
        ObjectinArrayOnOff(false, useCards, "Z");
        ObjectinArrayOnOff(false, useCards, "K");
        ObjectinArrayOnOff(false, useCards, "C");
        ObjectinArrayOnOff(false, useCards, "H");
    }
    public void GimmickK()
    {
        BringCard("K");
        cardQueue.Enqueue("K_1");
    }
    public void GimmickR()
    {
        BringCard("R");
        cardQueue.Enqueue("R_1");
    }
    public void GimmickR_1()
    {
        ObjectinArrayOnOff(false, useCards, "R");
    }

    // 벌점카드
    public void Gimmick66()
    {
        BringCard("66");
        cardQueue.Enqueue("66_1");
    }
    public void Gimmick66_1()
    {
        ObjectinArrayOnOff(false, useCards, "1");
        ObjectinArrayOnOff(false, useCards, "66");
    }
    public void GimmickF()
    {
        BringCard("F");
        cardQueue.Enqueue("F_1");
    }
    public void GimmickF_1()
    {
        ObjectinArrayOnOff(false, useCards, "H");
        ObjectinArrayOnOff(false, useCards, "F");
    }
    public void GimmickL()
    {
        BringCard("L");
        cardQueue.Enqueue("L_1");
    }
    public void GimmickL_1()
    {
        ObjectinArrayOnOff(false, useCards, "L");
    }
    public void GimmickA()
    {
        BringCard("A");
        cardQueue.Enqueue("A_1");
    }
    public void GimmickA_1()
    {
        ObjectinArrayOnOff(false, useCards, "A");
    }
    public void GimmickW()
    {
        BringCard("W");
        cardQueue.Enqueue("W_1");
    }
    public void GimmickW_1()
    {
        ObjectinArrayOnOff(false, useCards, "W");
    }
    public void Gimmick44()
    {
        BringCard("44");
        cardQueue.Enqueue("44_1");
    }
    public void Gimmick44_1()
    {
        ObjectinArrayOnOff(false, useCards, "44");
    }
    public void Gimmick33()
    {
        BringCard("33");
        cardQueue.Enqueue("33_1");
    }
    public void Gimmick33_1()
    {
        ObjectinArrayOnOff(false, useCards, "33");
    }
    public void Gimmick14()
    {
        BringCard("14");
        cardQueue.Enqueue("14_1");
    }
    public void Gimmick14_1()
    {
        ObjectinArrayOnOff(false, useCards, "14");
    }
    public void Gimmick64()
    {
        BringCard("64");
        cardQueue.Enqueue("64_1");
    }
    public void Gimmick64_1()
    {
        ObjectinArrayOnOff(false, useCards, "64");
    }
    public void GimmickC()
    {
        BringCard("C");
        cardQueue.Enqueue("C_1");
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
