using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class GMaster : MonoBehaviour
{



    public Transform energyObj;
    public Transform hurdle2;
    public Transform Fox1;
    public Transform greenbase;
    public int randNumber;
    public float zScenePos = 18;
	public float waittoload = 0;
    public static string lvlCompStatus = "";
	public static int energyTotal = 0;

	
    // Start is called before the first frame update
    void Start()
    {
     Instantiate(greenbase,new Vector3(0,0,23),greenbase.rotation);  
     Instantiate(greenbase,new Vector3(0,0,36),greenbase.rotation);  
      Instantiate(greenbase,new Vector3(0,0,59),greenbase.rotation);  
      Instantiate(greenbase,new Vector3(0,0,82),greenbase.rotation); 


    }

    // Update is called once per frame
    void Update()
    {
    if (zScenePos < 150 && zScenePos > 15)
        {
            randNumber = Random.Range(0, 11);
            if (randNumber < 5)
            {
                if (randNumber == 0)
                {
                    Instantiate(energyObj, new Vector3(-2.5f, .5f, zScenePos), energyObj.rotation);
                }
                else if (randNumber == 1)
                {
                    Instantiate(energyObj, new Vector3(0, .5f, zScenePos), energyObj.rotation);
                }
                else if (randNumber == 2)
                {
                    Instantiate(energyObj, new Vector3(2.5f, .5f, zScenePos), energyObj.rotation);
                }
				if (randNumber == 3)
                {
                    Instantiate(energyObj, new Vector3(-2.5f, .5f, zScenePos), energyObj.rotation);
                }
				 if (randNumber == 4)
                {
                    Instantiate(energyObj, new Vector3(0, .5f, zScenePos), energyObj.rotation);
                }
            }
            if(randNumber == 5)
            {
                Instantiate(Fox1, new Vector3(-1.5f, 0, zScenePos), Fox1.rotation);
            }
            if (randNumber == 6)
            {
                Instantiate(hurdle2, new Vector3(0.0f, 0, zScenePos), hurdle2.rotation);
            }
            if (randNumber == 7)
            {
                Instantiate(Fox1, new Vector3(1.5f, 0, zScenePos), Fox1.rotation);
            }
            if (randNumber == 8)
            {
                Instantiate(hurdle2, new Vector3(-2.7f, 0, zScenePos), hurdle2.rotation);
            }
			if (randNumber == 9)
            {
                Instantiate(Fox1, new Vector3(1.5f, 0, zScenePos), Fox1.rotation);
            }	
            if (randNumber == 10)
            {
                Instantiate(hurdle2, new Vector3(2.7f, 0, zScenePos), hurdle2.rotation);
            }
			
			
            
            Instantiate(greenbase, new Vector3(0, 0, zScenePos), greenbase.rotation);
            zScenePos += 6;
        }
		if (lvlCompStatus == "Fail")
        {
            //SceneManager.LoadScene("LevelComp_new");
			waittoload += Time.deltaTime;
			
        }
        if (waittoload > 2)
        {
           SceneManager.LoadScene("LevelComp_new 1");
        }
        
    }
}
