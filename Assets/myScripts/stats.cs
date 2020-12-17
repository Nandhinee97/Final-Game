using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "energytxt")
        {
            GetComponent<TextMesh>().text = "Energy : " + GM.energyTotal;
        }
        if (gameObject.name == "status")
        {
            GetComponent<TextMesh>().text = GM.lvlCompStatus;
        }
		if (gameObject.name == "energytxt")
        {
            GetComponent<TextMesh>().text = "Energy Total : " + GMaster.energyTotal;
        }
		if (gameObject.name == "status")
        {
            GetComponent<TextMesh>().text = GMaster.lvlCompStatus;
        }
		
    }
}
