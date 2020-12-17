using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energy_stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
