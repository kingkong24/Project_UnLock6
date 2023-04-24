using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolutionButtonManager : MonoBehaviour
{
    private int Counter = 0;

    private void Awake()
    {
        Screen.SetResolution(1920, 1080, true);
    }

    public void SetResolution()
    {
        if (Counter == 0)
        {
            Screen.SetResolution(2560, 1140, true);
        }
        if (Counter == 1)
        {
            Screen.SetResolution(3840, 2160, true);
        }
        if (Counter == 2)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        Counter += 1;
        if (Counter == 3)
        {
            Counter = 0;
        }
    }
}
