using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public int buttonWidth;
    public int buttonHeight;
    private int origin_x;
    private int origin_y;
    public GUISkin mySkin;

    // Start is called before the first frame update
    void Start()
    {
        buttonWidth = 400;
        buttonHeight = 80;
        origin_x = Screen.width / 3 - buttonWidth / 3;
        origin_y = Screen.height / 2 - buttonHeight * 2;
    }
    void OnGUI()
    {
        GUI.skin = mySkin;
        if (GUI.Button(new Rect(origin_x, origin_y, buttonWidth, buttonHeight), "Play"))
        {
            SceneManager.LoadScene("Scene1");
        }
        if (GUI.Button(new Rect(origin_x, origin_y + buttonHeight + 40, buttonWidth, buttonHeight), "Quit"))
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}
