using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enegry_effect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "energy")
		{
			transform.Rotate(1,3,2);
		}
		
    }
}
