using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarAppear : MonoBehaviour
{
	[SerializeField] private GameObject myHealthBar;
	
	public void ActivateBar()
	{
		myHealthBar.SetActive(true);
	}
    
	
}
