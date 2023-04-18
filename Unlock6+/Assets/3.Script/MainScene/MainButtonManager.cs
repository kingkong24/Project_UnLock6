using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainButtonManager : MonoBehaviour
{
    [SerializeField] public GameObject[] RemoveGroup;
    [SerializeField] public GameObject[] AddGroup;

    // �ش� ���� �ҷ���
    public void SceneLoader(string Scenename)
    {
        SceneManager.LoadScene(Scenename, LoadSceneMode.Single);
    }

    // ���α׷� ����
    public void ProgramSet(string Scenename)
    {
        Application.Quit();
    }

    // MainSelect�� ����� GameSelect�� ������
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
