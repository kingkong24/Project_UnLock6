using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonManager : MonoBehaviour
{
    [SerializeField] public GameObject[] RemoveGroup;
    [SerializeField] public GameObject[] AddGroup;

    // 해당 씬을 불러옴
    public void SceneLoader(string Scenename)
    {
        SceneManager.LoadScene(Scenename, LoadSceneMode.Single);
    }

    // 프로그램 종료
    public void ProgramSet(string Scenename)
    {
        Application.Quit();
    }

    // MainSelect를 숨기고 GameSelect를 보여줌
    public void GroupOpen()
    {
        foreach (GameObject group in RemoveGroup)
        {
            group.SetActive(false);
        }
        foreach (GameObject group in AddGroup)
        {
            group.SetActive(true);
        }
    }
}
