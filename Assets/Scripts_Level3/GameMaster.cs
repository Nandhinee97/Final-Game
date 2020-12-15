using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
	public static int energyTotal = 0;
	public Transform cityBase;
	public Transform energybar;
	public float waittoload = 0;
	
	public static float zVelAdj = 1;
	
	public static string lvlCompStatus = "";
	
    // Start is called before the first frame update
    void Start()
    {
         Instantiate(cityBase, new Vector3(-6,0,48),cityBase.rotation);
		 Instantiate(cityBase, new Vector3(-6,0,84),cityBase.rotation);
		 Instantiate(cityBase, new Vector3(-6,0,120),cityBase.rotation);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
        if(lvlCompStatus == "Fail")
		{
			waittoload += Time.deltaTime;
		}
		
		if(waittoload > 2)
		{
			SceneManager.LoadScene("LevelComp");
		}
    }
}
