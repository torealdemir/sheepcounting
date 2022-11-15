using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepKill : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            GameController.instance.sheepCount++;
            other.gameObject.GetComponent<ormana>().enabled = false;
            other.gameObject.tag = "Player";
            

        }
    }




}
