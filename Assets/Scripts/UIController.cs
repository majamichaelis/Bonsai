using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public void RestartScene()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void CloseApplication()
    {
        Application.Quit();
    }

}
