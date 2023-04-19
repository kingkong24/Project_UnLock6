using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    // ����� �ͼ�
    public AudioMixer audioMixer;

    // �����̴�
    public Slider BgmSlider;


    // ���� ����
    public void SetBgmVolme()
    {
        // �α� ���� �� ����
        audioMixer.SetFloat("BGM", Mathf.Log10(BgmSlider.value) * 20);
    }
}
