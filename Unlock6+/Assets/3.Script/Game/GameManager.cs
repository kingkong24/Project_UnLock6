using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] informationCards, useCards;
    public static Queue<string> cardQueue = new Queue<string>();
    public static string curCard;

    [SerializeField] public GameObject[] cardInformationUI;
    [SerializeField] public GameObject informationDeck;
    [SerializeField] public GameObject useDeck;

    private void Awake()
    {
        // 오브젝트 배열 생성
        informationCards = ObjectsAsArray(informationDeck);
        useCards = ObjectsAsArray(useDeck);

        // informationCards, cardInformationUI 비활성화
        ObjectsArrayOnOff(true, cardInformationUI);
        ObjectsArrayOnOff(false, informationCards);

        // useDeck 위치 초기화
        foreach (GameObject group in useCards)
        {
            group.transform.position = new Vector3(20, -12, 0);
        }
    }

    void Start()
    {
        // 0 가져오기
        curCard = "0";
        ObjectinArrayOnOff(true, informationCards, "0");
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

    // 오브젝트 배열 ON/OFF
    public void ObjectsArrayOnOff(bool IsOn, GameObject[] objects)
    {
        foreach (GameObject group in objects)
        {
            group.SetActive(IsOn);
        }
    }

    // 오브젝트 배열 중 특정 오브젝트 ON/OFF
    public void ObjectinArrayOnOff(bool IsOn, GameObject[] objects, string objectName)
    {
        foreach (GameObject group in objects)
        {
            if (group.name == objectName)
            {
                group.SetActive(IsOn);
            }
        }
    }

    // 오브젝트 배열 중 특정 오브젝트 위치 옮기기
    public void ObjectinArrayPosition(Vector3 vector3, GameObject[] objects, string objectName)
    {
        foreach (GameObject group in objects)
        {
            if (group.name == objectName)
            {
                group.transform.position = vector3;
            }
        }
    }

}