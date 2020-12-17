using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMaster : MonoBehaviour
{



    public Transform energyObj;
    public Transform hurdle2;
    public Transform Fox1;
    public Transform greenbase;
    public int randNumber;
     public float zScenePos = 18;
	
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
            randNumber = Random.Range(0, 10);
            if (randNumber < 3)
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
            }
            if(randNumber == 3)
            {
                Instantiate(Fox1, new Vector3(-1.5f, 0, zScenePos), Fox1.rotation);
            }
            if (randNumber == 4)
            {
                Instantiate(hurdle2, new Vector3(0.0f, 0, zScenePos), hurdle2.rotation);
            }
            if (randNumber == 5)
            {
                Instantiate(Fox1, new Vector3(1.5f, 0, zScenePos), Fox1.rotation);
            }
            if (randNumber == 6)
            {
                Instantiate(hurdle2, new Vector3(-2.7f, 0, zScenePos), hurdle2.rotation);
            }
	    if (randNumber == 7)
            {
                Instantiate(Fox1, new Vector3(1.5f, 0, zScenePos), Fox1.rotation);
            }	
            if (randNumber == 8)
            {
                Instantiate(hurdle2, new Vector3(2.7f, 0, zScenePos), hurdle2.rotation);
            }

            
            Instantiate(greenbase, new Vector3(0, 0, zScenePos), greenbase.rotation);
            zScenePos += 6;
        }
        
    }
}
