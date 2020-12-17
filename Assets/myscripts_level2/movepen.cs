using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class movepen : MonoBehaviour
{

public KeyCode moveL;
public KeyCode moveR;
public KeyCode jump;

public float horizVel = 0;
public int laneNum = 4;
public string controlLocked = "n";


public float jumpheight=7f;
private Rigidbody rb;

	[SerializeField]
	Slider healthBar;
	

	[SerializeField]UnityEvent myTrigger;
		
	float maxHealth = 100;
	float currHealth = 5;


    // Start is called before the first frame update
    void Start()
    {
		healthBar.value = currHealth;
		rb=  GetComponent<Rigidbody>();
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


	if (Input.GetKeyDown(jump))
{
rb.AddForce(Vector3.up*jumpheight);
}
	
	//if (Input.GetKey("space"))
	  //    {
       //GetComponent<Rigidbody>().velocity = new Vector3(0,6,5);
        //StartCoroutine(stopJump());
        //}
}
	void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "lethal")                                             // ends sequence
        {   
	    //SoundManagerScript.PlaySound("collide");	
	    
            Destroy(gameObject);
			GMaster.lvlCompStatus = "Fail";
                                                                 // move to fail sequence
        }
	 if (other.gameObject.name == "energy(Clone)")                                             // ends sequence
        {   
	    //SoundManagerScript.PlaySound("collide");	
	    
            Destroy(other.gameObject);
			healthBar.value += 2;
			GMaster.energyTotal += 1;
                                                                 // move to fail sequence
        }
	
	if (other.gameObject.name == "Foxprefab(Clone)")                                             // ends sequence
        {   
	    //SoundManagerScript.PlaySound("collide");	
	    
            Destroy(gameObject);
			GMaster.lvlCompStatus = "Fail";
                                                                 // move to fail sequence
        }
		
	if(other.gameObject.name == "exit")
		{
			Destroy(other.gameObject);
			GMaster.lvlCompStatus = "Success!";
			SceneManager.LoadScene ("LevelComp");
		}
    }
	
	

IEnumerator stopSlide()
{
yield return new WaitForSeconds(.5f);
horizVel = 0;
controlLocked = "n";
}

//IEnumerator stopJump()
  //  {
    //    yield return new WaitForSeconds(0.5f);
	//	GetComponent<Rigidbody>().velocity = new Vector3(0,-6,5);
        //yield return new WaitForSeconds(0.5f);
	//	GetComponent<Rigidbody>().velocity = new Vector3(0,0,5);
    //}

}

