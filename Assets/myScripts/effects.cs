using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effects : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "energy(Clone)")
        {
            transform.Rotate(0, 3, 0);
        }
    }
}
