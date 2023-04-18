using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] informationCards, useCards;
    public static Queue<string> cardQueue = new Queue<string>();
    public static Dictionary<string, bool> IsRun;
    public static string curCard;

    [SerializeField] public GameObject[] cardInformationUI;
    [SerializeField] public GameObject informationDeck;
    [SerializeField] public GameObject useDeck;

    private void Awake()
    {
        Initialize();
    }

    // 초기화
    public void Initialize()
    {
        // 오브젝트 배열 생성
        informationCards = ObjectsAsArray(informationDeck);
        useCards = ObjectsAsArray(useDeck);

        // useDeck 위치 및 사용 여부 초기화 
        IsRun = new Dictionary<string, bool>();
        foreach (GameObject group in useCards)
        {
            if (!IsRun.ContainsKey(group.name))
            {
                IsRun.Add(group.name, false);
            }
            group.transform.position = new Vector3(20, -12, 0);
        }

        // informationCards,  useCards 비활성화, cardInformationUI 활성화
        ObjectsArrayOnOff(true, cardInformationUI);
        ObjectsArrayOnOff(false, informationCards);
        ObjectsArrayOnOff(false, useCards);

        // 0 가져오기
        curCard = "0";
        ObjectinArrayOnOff(true, informationCards, "0");
        ObjectinArrayOnOff(true, useCards, "0");
        ObjectinArrayPosition(new Vector3(0, 0, 0), useCards, "0");
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