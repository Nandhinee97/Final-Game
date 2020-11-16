using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalEvent : MonoBehaviour
{
	public UnityEngine.Events.UnityEvent event1;
	
	
	public Transform obj1;
	public Transform obj2;

    // Update is called once per frame
    void Update()
    {
		float distance = Vector3.Distance(obj1.position, obj2.position);
		if(distance < 1)
			event1.Invoke();
    }
}
