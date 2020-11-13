using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameProg : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;

    // Start is called before the first frame update
    void Start()
    {
        nextTileSpawn.z = 15;
        StartCoroutine(spawnTile());
    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        nextTileSpawn.z += 3;
        StartCoroutine(spawnTile());
    }
}
