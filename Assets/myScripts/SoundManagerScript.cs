using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

public static AudioClip scollide,sjump,scollect,srun;
static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
	//scollide = Resources.Load<AudioClip>("collidesound");
     	sjump = Resources.Load<AudioClip>("jumpsound");
	//scollect = Resources.Load<AudioClip>("energysound");
	srun = Resources.Load<AudioClip>("Snowrunning");  

	audioSrc = GetComponent<AudioSource>();	
    }

public void collision()
{
scollide = Resources.Load<AudioClip>("collidesound");
audioSrc.PlayOneShot(scollide);
}

public void collecting()
{
scollect = Resources.Load<AudioClip>("energysound");
audioSrc.PlayOneShot(scollect);
}

    // Update is called once per frame
    void Update(){
	
    }
  
   public static void PlaySound(string clip)
    {
     switch(clip){
	//case "collide":
	//	audioSrc.PlayOneShot(scollide);
          //      break;
	case "jump":
		audioSrc.PlayOneShot(sjump);
                break;
	//case "collect":
	//	audioSrc.PlayOneShot(scollect);
          //      break;
	case "run":
		audioSrc.PlayOneShot(srun);
                break;
	}
	
     
    }
}
