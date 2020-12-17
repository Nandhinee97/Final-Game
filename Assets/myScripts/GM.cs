using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public static float vertVel = 0;
    public static int energyTotal = 0;
    public static float zVelAdj = 1;
    public float waittoload = 0;
    public static string lvlCompStatus = "";

    public Transform bbBase;
    public float zScenePos = 18;

    public Transform energyObj;
    public Transform jumpLObj;
    public Transform jumpRObj;
    public Transform wedgeLObj;
    public Transform wedgeRObj;
    public Transform wallLObj;
    public Transform wallRObj;

    public int randNumber;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bbBase, new Vector3(0,0,0), bbBase.rotation);
        Instantiate(bbBase, new Vector3(0, 0, 3), bbBase.rotation);
        Instantiate(bbBase, new Vector3(0, 0, 6), bbBase.rotation);
        Instantiate(bbBase, new Vector3(0, 0, 9), bbBase.rotation);
        Instantiate(bbBase, new Vector3(0, 0, 12), bbBase.rotation);
        Instantiate(bbBase, new Vector3(0, 0, 15), bbBase.rotation);

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (zScenePos < 120 && zScenePos > 12)
        {
            randNumber = Random.Range(0, 10);
            if (randNumber < 3)
            {
                if (randNumber == 0)
                {
                    Instantiate(energyObj, new Vector3(-1.3f, .5f, zScenePos), energyObj.rotation);
                }
                else if (randNumber == 1)
                {
                    Instantiate(energyObj, new Vector3(0, .5f, zScenePos), energyObj.rotation);
                }
                else if (randNumber == 2)
                {
                    Instantiate(energyObj, new Vector3(1.3f, .5f, zScenePos), energyObj.rotation);
                }
            }
            if(randNumber == 3)
            {
                Instantiate(jumpLObj, new Vector3(-1.5f, 0, zScenePos), jumpLObj.rotation);
            }
            if (randNumber == 4)
            {
                Instantiate(jumpRObj, new Vector3(.6f, 0, zScenePos), jumpRObj.rotation);
            }
            if (randNumber == 5)
            {
                Instantiate(wedgeLObj, new Vector3(-2.2f, 0, zScenePos), wedgeLObj.rotation);
            }
            if (randNumber == 6)
            {
                Instantiate(wedgeRObj, new Vector3(-.2f, 0, zScenePos), wedgeRObj.rotation);
            }
            if (randNumber == 7)
            {
                Instantiate(wallLObj, new Vector3(-1.6f, -.2f, zScenePos), wallLObj.rotation);
            }
            if (randNumber == 8)
            {
                Instantiate(wallRObj, new Vector3(.9f, -.2f, zScenePos), wallRObj.rotation);
            }

            
            Instantiate(bbBase, new Vector3(0, 0, zScenePos), bbBase.rotation);
            zScenePos += 3;
        }
        if (lvlCompStatus == "Fail")
        {
            waittoload += Time.deltaTime;
        }
        if (waittoload > 2)
        {
           SceneManager.LoadScene("LevelComp_new");
        }
    }
}
