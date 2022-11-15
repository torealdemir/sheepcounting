using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using DG.Tweening;

public class ormana : MonoBehaviour
{


    public Transform woodyard;
    public Transform farm;

    private Rigidbody2D rb;


    float angle = 90f;
    float initialVelocity = 7f;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        woodyard = GameObject.FindGameObjectWithTag("woodyard").transform;
        farm = GameObject.FindGameObjectWithTag("Farm").transform;
    }


    void Update()
    {
        jumpMechanic();

        float angle = this.angle * Mathf.Deg2Rad; 

        if(transform.position.y <= 0)
        {
            transform.position = new Vector2(transform.position.x, 0);
        }

    }

    private void DontWalk()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }



    void Walk()
    {
        //transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);

        transform.DOMove(Vector3.zero, 4f);
    }

    IEnumerator JumpAndForward(float v0, float angle)
    {
        float t = 0;
        while (t < 100)
        {

            float x = v0 * t * Mathf.Cos(angle);
            float y = v0 * t * Mathf.Sin(angle) - (1f / 2f) * -Physics.gravity.y * Mathf.Pow(t, 2);
            transform.position = new Vector3(x, y, 0);


            t += Time.deltaTime;
            yield return null;
        }
        

    }

    void jumpMechanic()
    {



        if (gameObject.transform.position.x >= woodyard.transform.position.x)
        {
            Walk();

        }
        else
        {
            DontWalk();
           
            
        }

        if (gameObject.transform.position.x < woodyard.transform.position.x && Input.GetMouseButtonDown(0))
        {

            StopAllCoroutines();
            StartCoroutine(JumpAndForward(initialVelocity, angle));

        }
    }

    
}