using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public static CanvasController instance;


    public GameObject startScreen;



    private void Start()
    {

        instance = this;
    }
}
