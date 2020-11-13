using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMenu : MonoBehaviour
{
    public GUISkin mySkin;

    void OnGUI()
    {
        GUI.skin = mySkin;
        if (GUI.Button(new Rect(20, 20, 100, 50), "Menu"))
            SceneManager.LoadScene(0);
    }
}
