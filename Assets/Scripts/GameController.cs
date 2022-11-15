using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    [SerializeField] private GameObject sheepPrefab;
    [SerializeField] GameObject sheepOnScene;
    //private bool isThereAnySheep = true;
    public int sheepCount;


    private void Start()
    {
        instance = this;
    }


    private void Update()
    {
        sheepOnScene = GameObject.FindGameObjectWithTag("Sheep");
        if (sheepOnScene == null)
        {
            Instantiate(sheepPrefab, transform.position, transform.rotation);
        }
    }

   

    
    
}
