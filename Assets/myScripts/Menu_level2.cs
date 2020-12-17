using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Menu_level2 : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
