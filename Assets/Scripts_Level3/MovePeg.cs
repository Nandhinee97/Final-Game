using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MovePeg : MonoBehaviour
{
	public KeyCode moveL;
	public KeyCode moveR;
	public KeyCode moveJ;
	
	public float horizVel = 0;
	//public int laneNum = 4;
	public string controlLocked = "n";
	//public static int energyTotal = 0;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3 (horizVel,0,4);
		
		if ((Input.GetKeyDown(moveL))&& (controlLocked == "n"))
		{
			horizVel = -4;
			StartCoroutine(stopSlide());
			//laneNum -= 1;
			controlLocked = "y";
			
		}
		if ((Input.GetKeyDown(moveR))&& (controlLocked == "n"))
		{
			horizVel = 4;
			StartCoroutine(stopSlide());
			//laneNum += 1;
			controlLocked = "y";	
		}
		
		if ((Input.GetKeyDown(moveJ))&& (controlLocked == "n"))
        {
		 SoundManagerScript.PlaySound("jump");	
         GetComponent<Rigidbody>().velocity = new Vector3(0,3,3);
         StartCoroutine(stopJump());
        }
    }
	
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "obstacle")
		{
			Destroy(gameObject);
		}
		if(other.gameObject.name == "energy")
		{
			Destroy(other.gameObject);
			GameMaster.energyTotal += 1;
		}
		if(other.gameObject.name == "exit")
		{
			Destroy(other.gameObject);
			SceneManager.LoadScene ("LevelComp");
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
        yield return new WaitForSeconds(1);
		GetComponent<Rigidbody>().velocity = new Vector3(0,-3,3);
        yield return new WaitForSeconds(0.5f);
		GetComponent<Rigidbody>().velocity = new Vector3(0,0,3);
    }
}
