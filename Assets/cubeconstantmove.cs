using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeconstantmove : MonoBehaviour
{
    Manager GameManager;
    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime);
    }
}
