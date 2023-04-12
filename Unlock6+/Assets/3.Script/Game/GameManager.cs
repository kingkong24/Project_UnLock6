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
        // ������Ʈ �迭 ����
        informationCards = ObjectsAsArray(informationDeck);
        useCards = ObjectsAsArray(useDeck);

        // informationCards, cardInformationUI ��Ȱ��ȭ
        ObjectsArrayOnOff(false, cardInformationUI);
        ObjectsArrayOnOff(false, informationCards);

        // useDeck ��ġ �ʱ�ȭ
        foreach (GameObject group in useCards)
        {
            group.transform.position = new Vector3(20, -12, 0);
        }

        // Queue�� 0ī�� �ֱ�
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

    // ������Ʈ �迭 ON/OFF
    private void ObjectsArrayOnOff(bool IsOn , GameObject[] objects)
    {
        foreach (GameObject group in objects)
        {
            group.SetActive(IsOn);
        }
    }

    // ������Ʈ �迭 �� Ư�� ������Ʈ ON/OFF
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

    // GameObject�� ��ӵ� Object���� �迭�� ����
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
