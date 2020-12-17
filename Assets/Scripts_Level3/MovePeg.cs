using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class MovePeg : MonoBehaviour
{
	public KeyCode moveL;
public KeyCode moveR;


public float horizVel = 0;
public int laneNum = 4;
public string controlLocked = "n";


	[SerializeField]
	Slider healthBar;
	

	[SerializeField]UnityEvent myTrigger;
		
	float maxHealth = 100;
	float currHealth = 5;


    // Start is called before the first frame update
    void Start()
    {
		healthBar.value = currHealth;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3 (horizVel,0,6);

		if ((Input.GetKeyDown(moveL))&& (controlLocked == "n")&& (laneNum > 1))
		{
			horizVel = -2.5f;
			StartCoroutine(stopSlide());
			laneNum -= 1;
			controlLocked = "y";
		}
		
		if ((Input.GetKeyDown(moveR))&& (controlLocked == "n")&& (laneNum < 6))
		{
			horizVel = 2.5f;
			StartCoroutine(stopSlide());
			laneNum += 1;
			controlLocked = "y";
		}
	
		if (Input.GetKey("space"))
		{
			SoundManagerScript.PlaySound("jump");	
			GetComponent<Rigidbody>().velocity = new Vector3(0,6,5);
			StartCoroutine(stopJump());
        }
}
	void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "lethal")                                             // ends sequence
        {   
	    	
	    
            Destroy(gameObject);
			//SoundManagerScript.PlaySound("collide");
			GameMaster.lvlCompStatus = "Fail";
                                                                 // move to fail sequence
        }
	 if (other.gameObject.name == "energy(Clone)")                                             // ends sequence
        {   
	    	
	    
            Destroy(other.gameObject);
			//SoundManagerScript.PlaySound("collect");
			healthBar.value += 2;
			GMaster.energyTotal += 1;
                                                                 // move to fail sequence
        }
	
	if (other.gameObject.name == "Foxprefab(Clone)")                                             // ends sequence
        {   
	    	
	    
            Destroy(gameObject);
			GameMaster.lvlCompStatus = "Fail";
			//SoundManagerScript.PlaySound("collide");
			//GameMaster.lvlCompStatus = "Fail";
			
                                                                 // move to fail sequence
        }
		
		
	if(other.gameObject.name == "exit")
		{
			Destroy(other.gameObject);
			GameMaster.lvlCompStatus = "Success!";
			SceneManager.LoadScene ("LevelComp_new 1");
		}
    }
	
	

IEnumerator stopSlide()
{
yield return new WaitForSeconds(.5f);
horizVel = 0;
controlLocked = "n";
}

IEnumerator stopJump()
{
    yield return new WaitForSeconds(0.5f);
	GetComponent<Rigidbody>().velocity = new Vector3(0,-6.3f,5);
	yield return new WaitForSeconds(0.5f);
	GetComponent<Rigidbody>().velocity = new Vector3(0,0,5);
 }

}

