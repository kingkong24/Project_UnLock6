using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
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
