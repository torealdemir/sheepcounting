using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CounterText : MonoBehaviour
{
    public TextMeshProUGUI tmp;


    private void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        tmp.text = "Sheeps: " + GameController.instance.sheepCount;
    }
}
