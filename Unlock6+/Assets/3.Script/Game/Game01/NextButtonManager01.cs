using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Reflection;

public class NextButtonManager01 : GameManager
{
    [SerializeField] public BoardControl01 Board;
    [SerializeField] public GameObject GameObjectboard;
    [SerializeField] public GameObject CardSet;
    [SerializeField] public Sprite front0, back0, front1, back1, front2, back2, front3, back3, front4, back4, front5, back5, front6, back6;
    [SerializeField] private AudioClip DonSound;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Camera cam;
    public Sprite front, back;
    public bool isfront = true;
    private List<string> targetCard;

    void OnEnable()
    {
        CardSet.SetActive(false);
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
    public void Gimmick0_1(){}
    public void Gimmick2()
    {
        BringCard("2");
        cardQueue.Enqueue("2_1");
    }
    public void Gimmick2_1()
    {
        targetCard = new List<string> { "15", "15_1", "29", "29_1", "47", "47_1" };
        BringCards(targetCard);
    }
    public void Gimmick15()
    {
        BringCard("15");
        cardQueue.Enqueue("15_1");
    }
    public void Gimmick29()
    {
        BringCard("29");
        cardQueue.Enqueue("29_1");
    }
    public void Gimmick47()
    {
        BringCard("47");
        cardQueue.Enqueue("47_1");
    }
    public void Gimmick68()
    {
        BringCard("68");
        cardQueue.Enqueue("68_1");
    }
    public void Gimmick68_1()
    {
        ObjectinArrayOnOff(false, useCards, "0");
        ObjectinArrayOnOff(false, useCards, "47");
    }
    public void Gimmick83()
    {
        BringCard("83");
        cardQueue.Enqueue("83_1");
    }
    public void Gimmick83_1()
    {
        ObjectinArrayOnOff(false, useCards, "15");
        ObjectinArrayOnOff(false, useCards, "68");
        targetCard = new List<string> { "33", "33_1", "84", "84_1" };
        BringCards(targetCard);
    }
    public void Gimmick33()
    {
        BringCard("33");
        cardQueue.Enqueue("33_1");
    }
    public void Gimmick84()
    {
        GameObjectboard.SetActive(true);
        BringCard("84");
        cardQueue.Enqueue("84_1");
    }
    public void Gimmick84_1()
    {
        ObjectinArrayOnOff(false, useCards, "84");
    }
    public void Gimmick33_1()
    {
        targetCard = new List<string> { "72", "72_1", "87", "87_1" };
        BringCards(targetCard);
    }
    public void Gimmick72()
    {
        BringCard("72");
        cardQueue.Enqueue("72_1");
    }
    public void Gimmick87()
    {
        BringCard("87");
        cardQueue.Enqueue("87_1");
    }
    public void Gimmick56()
    {
        BringCard("56");
        cardQueue.Enqueue("56_1");
    }

    public void Gimmick56_1()
    {
        cardQueue.Enqueue("Z");
    }

    public void GimmickZ()
    {
        if (!IsRun["Z"])
        {
            GameObjectboard.GetComponent<SpriteRenderer>().sprite = front1;
            Board.front = front1;
            Board.back = back1;
        }
        BringCard("Z");
        cardQueue.Enqueue("Z_1");
    }

    public void GimmickZ_1()
    {
        ObjectinArrayOnOff(false, useCards, "56");
    }

    public void Gimmick63()
    {
        BringCard("63");
        cardQueue.Enqueue("63_1");
    }
    public void Gimmick34()
    {
        BringCard("34");
        cardQueue.Enqueue("34_1");
    }
    public void Gimmick62()
    {
        if (!IsRun["62"])
        {
            GameObjectboard.GetComponent<SpriteRenderer>().sprite = front2;
            Board.front = front2;
            Board.back = back2;
        }
        BringCard("62");
        cardQueue.Enqueue("62_1");
    }
    public void Gimmick16()
    {
        BringCard("16");
        cardQueue.Enqueue("16_1");
    }

    public void Gimmick67()
    {
        BringCard("67");
        cardQueue.Enqueue("67_1");
    }

    public void Gimmick58()
    {
        BringCard("58");
        cardQueue.Enqueue("58_1");
    }
    public void Gimmick42()
    {
        if (!IsRun["42"])
        {
            GameObjectboard.GetComponent<SpriteRenderer>().sprite = front3;
            Board.front = front3;
            Board.back = back3;
        }
        BringCard("42");
        cardQueue.Enqueue("42_1");
    }
    public void Gimmick42_1()
    {
        ObjectinArrayOnOff(false, useCards, "58");
    }
    public void GimmickQ()
    {
        BringCard("Q");
        cardQueue.Enqueue("Q_1");
    }
    public void Gimmick27()
    {
        BringCard("27");
        cardQueue.Enqueue("27_1");
    }
    public void Gimmick27_1()
    {
        cardQueue.Enqueue("30");
    }
    public void Gimmick30()
    {
        BringCard("30");
        cardQueue.Enqueue("30_1");
    }
    public void Gimmick82()
    {
        BringCard("82");
        cardQueue.Enqueue("82_1");
    }
    public void Gimmick46()
    {
        BringCard("46");
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
        BringCard("22");
        cardQueue.Enqueue("22_1");
    }
    public void Gimmick64()
    {
        BringCard("64");
        cardQueue.Enqueue("64_1");
    }
    public void Gimmick64_1()
    {
        ObjectinArrayOnOff(false, useCards, "46");
    }
    public void Gimmick91()
    {
        if (!IsRun["91"])
        {
            GameObjectboard.GetComponent<SpriteRenderer>().sprite = front4;
            Board.front = front4;
            Board.back = back4;
        }
        BringCard("91");
        cardQueue.Enqueue("91_1");
    }
    public void Gimmick91_1()
    {
        ObjectinArrayOnOff(false, useCards, "27");
        ObjectinArrayOnOff(false, useCards, "64");
    }
    public void Gimmick12()
    {
        BringCard("12");
        cardQueue.Enqueue("12_1");
    }
    public void Gimmick12_1()
    {
        ObjectinArrayOnOff(false, useCards, "82");
        ObjectinArrayOnOff(false, useCards, "Q");
    }
    public void Gimmick59()
    {
        if (!IsRun["59"])
        {
            GameObjectboard.GetComponent<SpriteRenderer>().sprite = front5;
            Board.front = front5;
            Board.back = back5;
        }
        BringCard("59");
        cardQueue.Enqueue("59_1");
    }
    public void Gimmick59_1()
    {
        ObjectinArrayOnOff(false, useCards, "12");
    }
    public void Gimmick18()
    {
        BringCard("18");
        cardQueue.Enqueue("18_1");
    }
    public void Gimmick19()
    {
        BringCard("19");
        cardQueue.Enqueue("19_1");
    }
    public void Gimmick19_1()
    {
        ObjectinArrayOnOff(false, useCards, "18");
    }
    public void Gimmick76()
    {
        BringCard("76");
        cardQueue.Enqueue("76_1");
    }
    public void Gimmick76_1()
    {
        ObjectinArrayOnOff(false, useCards, "22");
    }
    public void Gimmick85()
    {
        if (!IsRun["85"])
        {
            GameObjectboard.GetComponent<SpriteRenderer>().sprite = front6;
            Board.front = front6;
            Board.back = back6;
        }
        BringCard("85");
        cardQueue.Enqueue("85_1");
    }
    public void Gimmick85_1()
    {
        ObjectinArrayOnOff(false, useCards, "19");
        cardQueue.Enqueue("75");
    }
    public void Gimmick75()
    {
        BringCard("75");
        cardQueue.Enqueue("75_1");
    }
    public void Gimmick75_1()
    {
        cardQueue.Enqueue("39");
    }
    public void Gimmick39()
    {
        BringCard("39");
        cardQueue.Enqueue("39_1");
    }
    public void Gimmick39_1()
    {
        ObjectinArrayOnOff(false, useCards, "75");
    }
    public void Gimmick31()
    {
        BringCard("31");
        cardQueue.Enqueue("31_1");
    }
    public void Gimmick70()
    {
        BringCard("70");
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
        BringCard("13");
        cardQueue.Enqueue("13_1");
    }
    public void Gimmick89()
    {
        BringCard("89");
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
        BringCard("66");
        cardQueue.Enqueue("66_1");
    }
    public void Gimmick66_1()
    {
        ObjectinArrayOnOff(false, useCards, "89");
    }
    public void Gimmick36()
    {
        BringCard("36");
        cardQueue.Enqueue("36_1");
    }
    public void Gimmick36_1()
    {
        ObjectinArrayOnOff(false, useCards, "66");
    }
    public void Gimmick32()
    {
        StartCoroutine(CameraSpin());
        audioSource.clip = DonSound;
        audioSource.Play();
        BringCard("32");
        cardQueue.Enqueue("32_1");
    }
    public void Gimmick32_1()
    {
        ObjectinArrayOnOff(false, useCards, "36");
        targetCard = new List<string> { "14", "14_1", "17", "17_1", "43", "43_1", "99", "99_1" };

        BringCards(targetCard);
    }
    public void Gimmick14()
    {
        BringCard("14");
        cardQueue.Enqueue("14_1");
    }
    public void Gimmick17()
    {
        BringCard("17");
        cardQueue.Enqueue("17_1");
    }
    public void Gimmick43()
    {
        BringCard("43");
        cardQueue.Enqueue("43_1");
    }
    public void Gimmick99()
    {
        BringCard("99");
        cardQueue.Enqueue("99_1");
    }
    public void Gimmick24()
    {
        BringCard("24");
        cardQueue.Enqueue("24_1");
    }
    public void Gimmick24_1()
    {
        ObjectinArrayOnOff(false, useCards, "99");
    }
    public void Gimmick77()
    {
        BringCard("77");
        cardQueue.Enqueue("77_1");
    }
    public void Gimmick77_1()
    {
        ObjectinArrayOnOff(false, useCards, "34");
        ObjectinArrayOnOff(false, useCards, "43");
    }
    public void Gimmick81()
    {
        BringCard("81");
        cardQueue.Enqueue("81_1");
    }
    public void Gimmick81_1()
    {
        ObjectinArrayOnOff(false, useCards, "14");
        ObjectinArrayOnOff(false, useCards, "67");
    }
    public void Gimmick71()
    {
        BringCard("71");
        cardQueue.Enqueue("71_1");
    }
    public void Gimmick71_1()
    {
        ObjectinArrayOnOff(false, useCards, "87");
    }
    public void Gimmick88()
    {
        BringCard("88");
        cardQueue.Enqueue("88_1");
    }
    public void Gimmick88_1()
    {
        ObjectinArrayOnOff(false, useCards, "17");
        ObjectinArrayOnOff(false, useCards, "71");
    }
    public void Gimmick52()
    {
        BringCard("52");
        cardQueue.Enqueue("52_1");
    }
    public void Gimmick52_1()
    {
        ObjectinArrayOnOff(false, useCards, "32");
        ObjectinArrayOnOff(false, useCards, "24");
        ObjectinArrayOnOff(false, useCards, "77");
        ObjectinArrayOnOff(false, useCards, "81");
        ObjectinArrayOnOff(false, useCards, "88");
        GameObjectboard.SetActive(false);
        CardSet.SetActive(true);
    }


    // 벌점카드
    public void Gimmick57()
    {
        BringCard("57");
        cardQueue.Enqueue("57_1");
    }
    public void Gimmick57_1()
    {
        ObjectinArrayOnOff(false, useCards, "57");
    }
    public void Gimmick45()
    {
        BringCard("45");
        cardQueue.Enqueue("45_1");
    }
    public void Gimmick45_1()
    {
        ObjectinArrayOnOff(false, useCards, "45");
    }
    public void Gimmick48()
    {
        BringCard("48");
        cardQueue.Enqueue("48_1");
    }
    public void Gimmick48_1()
    {
        ObjectinArrayOnOff(false, useCards, "48");
    }
    public void Gimmick61()
    {
        BringCard("61");
        cardQueue.Enqueue("61_1");
    }
    public void Gimmick61_1()
    {
        ObjectinArrayOnOff(false, useCards, "61");
    }
    public void Gimmick79()
    {
        BringCard("79");
        cardQueue.Enqueue("79_1");
    }
    public void Gimmick79_1()
    {
        ObjectinArrayOnOff(false, useCards, "79");
    }
    public void Gimmick80()
    {
        BringCard("80");
        cardQueue.Enqueue("80_1");
    }
    public void Gimmick80_1()
    {
        ObjectinArrayOnOff(false, useCards, "80");
    }
    public void Gimmick90()
    {
        BringCard("90");
        cardQueue.Enqueue("90_1");
    }
    public void Gimmick90_1()
    {
        ObjectinArrayOnOff(false, useCards, "90");
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

    IEnumerator CameraSpin()
    {
        float timer = 0f;
        float rotationTime = 2.5f;
        float rotationSpeed = 400.0f;

        while (timer < rotationTime)
        {
            Vector3 rotation = cam.transform.rotation.eulerAngles;
            rotation.z += Time.deltaTime * rotationSpeed;
            cam.transform.rotation = Quaternion.Euler(rotation);

            // 대기
            yield return new WaitForSeconds(0.01f);

            timer += 0.01f;
        }
        cam.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
    }
}
