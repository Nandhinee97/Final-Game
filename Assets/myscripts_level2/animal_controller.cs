using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animal_controller : MonoBehaviour {

private Transform _player;
public int speed=5;
public int distance =10;

void Start()
{
_player=GameObject.Find("PenguinFBX").transform;

}

void FixedUpdate()
{
if(Vector3.Distance(transform.position, _player.position)<=distance){
	transform.position= new Vector3(transform.position.x, transform.position.y, transform.position.z - speed* Time.deltaTime);

}
}


}
