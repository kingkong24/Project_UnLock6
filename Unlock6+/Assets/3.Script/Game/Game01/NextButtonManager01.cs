using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Reflection;

public class NextButtonManager01 : GameManager
{
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
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "0");
        cardQueue.Enqueue("0_1");
    }
    public void Gimmick2()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "2");
        cardQueue.Enqueue("2_1");
    }
    public void Gimmick2_1()
    {
        targetCard = new List<string> { "15", "15_1", "29", "29_1", "47", "47_1" };

        foreach (string group in targetCard)
        {
            ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, group);
            cardQueue.Enqueue(group);
        }
    }
    public void Gimmick68()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "68");
        cardQueue.Enqueue("68_1");
    }
    public void Gimmick68_1()
    {
        ObjectinArrayOnOff(false, useCards, "0");
        ObjectinArrayOnOff(false, useCards, "47");
    }
    public void Gimmick83()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "83");
        cardQueue.Enqueue("83_1");
    }
    public void Gimmick83_1()
    {
        ObjectinArrayOnOff(false, useCards, "15");
        ObjectinArrayOnOff(false, useCards, "68");
        targetCard = new List<string> { "33", "33_1", "84", "84_1" };

        foreach (string group in targetCard)
        {
            ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, group);
            cardQueue.Enqueue(group);
        }
    }

    public void Gimmick33_1()
    {
        targetCard = new List<string> { "72", "72_1", "87", "87_1" };

        foreach (string group in targetCard)
        {
            ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, group);
            cardQueue.Enqueue(group);
        }
    }

    public void Gimmick84_1()
    {
        ObjectinArrayOnOff(false, useCards, "84");
        // 보드를 가져온다.
    }

    public void Gimmick56()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "56");
        cardQueue.Enqueue("56_1");
    }

    public void Gimmick56_1()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "Z");
        cardQueue.Enqueue("Z");
    }

    public void GimmickZ()
    {
        cardQueue.Enqueue("Z_1");
    }

    public void GimmickZ_1()
    {
        ObjectinArrayOnOff(false, useCards, "56");
    }

    public void Gimmick63()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "63");
        cardQueue.Enqueue("63_1");
    }
    public void Gimmick34()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "34");
        cardQueue.Enqueue("34_1");
    }
    public void Gimmick62()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "62");
        cardQueue.Enqueue("62_1");
    }
    public void Gimmick16()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "16");
        cardQueue.Enqueue("16_1");
    }

    public void Gimmick67()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "67");
        cardQueue.Enqueue("67_1");
    }

    public void Gimmick58()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "58");
        cardQueue.Enqueue("58_1");
    }
    public void Gimmick42()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "42");
        cardQueue.Enqueue("42_1");
    }
    public void Gimmick42_1()
    {
        ObjectinArrayOnOff(false, useCards, "58");
    }
    public void GimmickQ()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "Q");
        cardQueue.Enqueue("Q_1");
    }
    public void Gimmick27()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "27");
        cardQueue.Enqueue("27_1");
    }
    public void Gimmick27_1()
    {
        cardQueue.Enqueue("30");
    }
    public void Gimmick30()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "30");
        cardQueue.Enqueue("30_1");
    }
    public void Gimmick82()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "82");
        cardQueue.Enqueue("82_1");
    }
    public void Gimmick46()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "46");
        cardQueue.Enqueue("46_1");
    }
    public void Gimmick46_1()
    {
        ObjectinArrayOnOff(false, useCards, "2");
        ObjectinArrayOnOff(false, useCards, "16");
        ObjectinArrayOnOff(false, useCards, "29");
        ObjectinArrayOnOff(false, useCards, "30");
    }
    public void Gimmick22()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "22");
        cardQueue.Enqueue("22_1");
    }
    public void Gimmick64()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "64");
        cardQueue.Enqueue("64_1");
    }
    public void Gimmick64_1()
    {
        ObjectinArrayOnOff(false, useCards, "46");
    }
    public void Gimmick91()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "91");
        cardQueue.Enqueue("91_1");
    }
    public void Gimmick91_1()
    {
        ObjectinArrayOnOff(false, useCards, "27");
        ObjectinArrayOnOff(false, useCards, "64");
    }
    public void Gimmick12()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "12");
        cardQueue.Enqueue("12_1");
    }
    public void Gimmick12_1()
    {
        ObjectinArrayOnOff(false, useCards, "82");
        ObjectinArrayOnOff(false, useCards, "Q");
    }
    public void Gimmick59()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "59");
        cardQueue.Enqueue("59_1");
    }
    public void Gimmick59_1()
    {
        ObjectinArrayOnOff(false, useCards, "12");
    }
    public void Gimmick18()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "18");
        cardQueue.Enqueue("18_1");
    }
    public void Gimmick19()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "19");
        cardQueue.Enqueue("19_1");
    }
    public void Gimmick19_1()
    {
        ObjectinArrayOnOff(false, useCards, "18");
    }
    public void Gimmick76()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "76");
        cardQueue.Enqueue("76_1");
    }
    public void Gimmick76_1()
    {
        ObjectinArrayOnOff(false, useCards, "22");
    }
    public void Gimmick85()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "85");
        cardQueue.Enqueue("85_1");
    }
    public void Gimmick85_1()
    {
        ObjectinArrayOnOff(false, useCards, "19");
        cardQueue.Enqueue("75");
    }
    public void Gimmick75()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "75");
        cardQueue.Enqueue("75_1");
    }
    public void Gimmick75_1()
    {
        cardQueue.Enqueue("39");
    }
    public void Gimmick39()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "39");
        cardQueue.Enqueue("39_1");
    }
    public void Gimmick39_1()
    {
        ObjectinArrayOnOff(false, useCards, "75");
    }
    public void Gimmick31()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "31");
        cardQueue.Enqueue("31_1");
    }
    public void Gimmick70()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "70");
        cardQueue.Enqueue("70_1");
    }
    public void Gimmick70_1()
    {
        ObjectinArrayOnOff(false, useCards, "31");
        ObjectinArrayOnOff(false, useCards, "39");
        cardQueue.Enqueue("13");
    }
    public void Gimmick13()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "13");
        cardQueue.Enqueue("13_1");
    }
    public void Gimmick89()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "89");
        cardQueue.Enqueue("89_1");
    }
    public void Gimmick89_1()
    {
        ObjectinArrayOnOff(false, useCards, "13");
        ObjectinArrayOnOff(false, useCards, "70");
        ObjectinArrayOnOff(false, useCards, "76");
    }
    public void Gimmick66()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "66");
        cardQueue.Enqueue("66_1");
    }
    public void Gimmick66_1()
    {
        ObjectinArrayOnOff(false, useCards, "89");
    }
    public void Gimmick36()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "36");
        cardQueue.Enqueue("36_1");
    }
    public void Gimmick36_1()
    {
        ObjectinArrayOnOff(false, useCards, "66");
    }
    public void Gimmick32()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "32");
        cardQueue.Enqueue("32_1");
    }
    public void Gimmick32_1()
    {
        ObjectinArrayOnOff(false, useCards, "36");
        targetCard = new List<string> { "14", "14_1", "17", "17_1", "43", "43_1", "99", "99_1" };

        foreach (string group in targetCard)
        {
            ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, group);
            cardQueue.Enqueue(group);
        }
    }
    public void Gimmick14()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "14");
    }
    public void Gimmick17()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "17");
    }
    public void Gimmick43()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "43");
    }
    public void Gimmick99()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "99");
    }
    public void Gimmick24()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "24");
        cardQueue.Enqueue("24_1");
    }
    public void Gimmick24_1()
    {
        ObjectinArrayOnOff(false, useCards, "99");
    }
    public void Gimmick77()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "77");
        cardQueue.Enqueue("77_1");
    }
    public void Gimmick77_1()
    {
        ObjectinArrayOnOff(false, useCards, "34");
        ObjectinArrayOnOff(false, useCards, "43");
    }
    public void Gimmick81()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "81");
        cardQueue.Enqueue("81_1");
    }
    public void Gimmick81_1()
    {
        ObjectinArrayOnOff(false, useCards, "14");
        ObjectinArrayOnOff(false, useCards, "67");
    }
    public void Gimmick71()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "71");
        cardQueue.Enqueue("71_1");
    }
    public void Gimmick71_1()
    {
        ObjectinArrayOnOff(false, useCards, "87");
    }
    public void Gimmick88()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "88");
        cardQueue.Enqueue("88_1");
    }
    public void Gimmick88_1()
    {
        ObjectinArrayOnOff(false, useCards, "17");
        ObjectinArrayOnOff(false, useCards, "71");
    }
    public void Gimmick52()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "52");
        cardQueue.Enqueue("52_1");
    }
    public void Gimmick52_1()
    {
        ObjectinArrayOnOff(false, useCards, "32");
        ObjectinArrayOnOff(false, useCards, "24");
        ObjectinArrayOnOff(false, useCards, "77");
        ObjectinArrayOnOff(false, useCards, "81");
        ObjectinArrayOnOff(false, useCards, "88");
        // 합체도면 생성
    }


    // 벌점카드
    public void Gimmick57()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "57");
        cardQueue.Enqueue("57_1");
    }
    public void Gimmick57_1()
    {
        ObjectinArrayOnOff(false, useCards, "57");
    }
    public void Gimmick45()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "45");
        cardQueue.Enqueue("45_1");
    }
    public void Gimmick45_1()
    {
        ObjectinArrayOnOff(false, useCards, "45");
    }
    public void Gimmick48()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "48");
        cardQueue.Enqueue("48_1");
    }
    public void Gimmick48_1()
    {
        ObjectinArrayOnOff(false, useCards, "48");
    }
    public void Gimmick61()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "61");
        cardQueue.Enqueue("61_1");
    }
    public void Gimmick61_1()
    {
        ObjectinArrayOnOff(false, useCards, "61");
    }
    public void Gimmick79()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "79");
        cardQueue.Enqueue("79_1");
    }
    public void Gimmick79_1()
    {
        ObjectinArrayOnOff(false, useCards, "79");
    }
    public void Gimmick80()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "80");
        cardQueue.Enqueue("80_1");
    }
    public void Gimmick80_1()
    {
        ObjectinArrayOnOff(false, useCards, "80");
    }
    public void Gimmick90()
    {
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "90");
        cardQueue.Enqueue("90_1");
    }
    public void Gimmick90_1()
    {
        ObjectinArrayOnOff(false, useCards, "90");
    }



    #endregion
}
