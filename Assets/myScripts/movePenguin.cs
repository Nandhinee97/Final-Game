using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class movePenguin : MonoBehaviour
{
    public KeyCode moveL;
    public KeyCode moveR;
    public float hVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";
    public int trip = 0;
    public Transform boomObj;
	public static int energyTotal = 0;
	
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
        GetComponent<Rigidbody>().velocity = new Vector3(hVel, GM.vertVel, 3);

        if(Input.GetKeyDown(moveL) && (laneNum > 1) && (controlLocked == "n"))
        {
            hVel = -2.5f;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }
        if (Input.GetKeyDown(moveR) && (laneNum < 3) && (controlLocked == "n"))
        {
            hVel = 2.5f;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }
	if (Input.GetKey("space"))
        {
		 SoundManagerScript.PlaySound("jump");	
         GetComponent<Rigidbody>().velocity = new Vector3(0,3,3);
         StartCoroutine(stopJump());
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstacle")                                             // ends sequence
        {   
	        SoundManagerScript.PlaySound("collide");	
			myTrigger.Invoke();
            Destroy(gameObject);
            GM.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);                     // penguin explosion
            GM.lvlCompStatus = "Fail";                                                      // move to fail sequence
        }
		if (other.gameObject.name == "exit")                    // success of level
        {
            GM.lvlCompStatus = "Success!";
            SceneManager.LoadScene("LevelComp");
        }
   
        if (other.gameObject.name == "energy(Clone)")           // collection of energy
        {
			SoundManagerScript.PlaySound("collect"); 
			Destroy(other.gameObject);
			 
			myTrigger.Invoke();			
			healthBar.value += 5;
            GM.energyTotal += 1;
			
        }
    }

    /* private void OnTriggerEnter(Collider other)                 // for trigger of effects start stop(change elev.) 
    {
        if (other.gameObject.name == "exit")                    // success of level
        {
            GM.lvlCompStatus = "Success!";
            SceneManager.LoadScene("LevelComp");
        }
   
        if (other.gameObject.name == "energy(Clone)")           // collection of energy
        {
			SoundManagerScript.PlaySound("collect"); 
			 GM.energyTotal += 1;
			Destroy(other.gameObject);
			 
			myTrigger.Invoke();			
			healthBar.value += 5;
            GM.energyTotal += 1;
			
        }
    } */

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        hVel = 0;
        controlLocked = "n";
    }
	
	IEnumerator stopJump()
    {
        yield return new WaitForSeconds(1);
		GetComponent<Rigidbody>().velocity = new Vector3(0,-3,3);
        yield return new WaitForSeconds(0.5f);
		GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
    }
}
