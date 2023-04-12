using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // 메인 버튼은 활성화하고, 게임 버튼은 비활성화.
    [SerializeField] public GameObject[] MainSelect;
    [SerializeField] public GameObject[] GameSelect;

    void Start()
    {
        foreach (GameObject group in GameSelect)
        {
            group.SetActive(false);
        }
        foreach (GameObject group in MainSelect)
        {
            group.SetActive(true);
        }
    }
}
