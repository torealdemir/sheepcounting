using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Scroller : MonoBehaviour
{
    public GameObject Moon;


    private void Start()
    {
        Moon = GameObject.FindGameObjectWithTag("Moon");
        Moon.transform.DORotate(new Vector3(0f, 0f, 360), 22.5f, RotateMode.FastBeyond360).SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }


    private void Update()
    {
        
    }
}
