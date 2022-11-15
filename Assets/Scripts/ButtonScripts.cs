using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{

    float clockTime;
    public void NormalStart()
    {
        CanvasController.instance.startScreen.SetActive(false);
    }


    public void FifteenMinStart()
    {
        
        clockTime += Time.deltaTime;

        if(clockTime >= 20)
        {
            Application.Quit();
        }

        CanvasController.instance.startScreen.SetActive(false);
    }


    public void DirectQuit()
    {
        Application.Quit();
    }


}
