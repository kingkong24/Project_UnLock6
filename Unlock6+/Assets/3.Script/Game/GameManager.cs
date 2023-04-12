using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject[] cardInformationUI;
    [SerializeField] private GameObject informationDeck;
    [SerializeField] private GameObject useDeck;
    private GameObject[] informationCards, useCards;
    Queue<string> cardQueue = new Queue<string>();
    private bool IsInformationOn = false;
    private string curCard;


    void Start()
    {
        // 오브젝트 배열 생성
        informationCards = ObjectsAsArray(informationDeck);
        useCards = ObjectsAsArray(useDeck);

        // informationCards, cardInformationUI 비활성화
        ObjectsArrayOnOff(false, cardInformationUI);
        ObjectsArrayOnOff(false, informationCards);

        // useDeck 위치 초기화
        foreach (GameObject group in useCards)
        {
            group.transform.position = new Vector3(20, -12, 0);
        }

        // Queue에 0카드 넣기
        cardQueue.Enqueue("0");
        cardQueue.Enqueue("0_1");
    }

    void Update()
    {
        if (cardQueue.Count == 0)
        {
            return;
        }

        string curCard = cardQueue.Dequeue();
        ObjectsArrayOnOff(true, cardInformationUI);
        ObjectinArrayOnOff(true, informationCards, curCard);

    }

    // 오브젝트 배열 ON/OFF
    private void ObjectsArrayOnOff(bool IsOn , GameObject[] objects)
    {
        foreach (GameObject group in objects)
        {
            group.SetActive(IsOn);
        }
    }

    // 오브젝트 배열 중 특정 오브젝트 ON/OFF
    private void ObjectinArrayOnOff(bool IsOn, GameObject[] objects, string objectName)
    {
        foreach (GameObject group in objects)
        {
            if (group.name == objectName)
            {
                group.SetActive(IsOn);
            }
        }
    }

    // GameObject에 상속된 Object들을 배열로 저장
    private GameObject[] ObjectsAsArray(GameObject objects)
    {
        GameObject[] ObjectsArray = new GameObject[objects.transform.childCount];
        for (int i = 0; i < objects.transform.childCount; i++)
        {
            ObjectsArray[i] = objects.transform.GetChild(i).gameObject;
        }
        return ObjectsArray;
    }
}
