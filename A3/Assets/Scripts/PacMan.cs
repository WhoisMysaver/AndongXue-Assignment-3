using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour
{
    private Transform[] points;
    private int currtenPoint=1;

    [SerializeField] private float speed;
    void Start()
    {
        points = GameObject.Find("Points").GetComponentsInChildren<Transform>();
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, points[currtenPoint].position, speed/(Vector3.Distance(transform.position,points[currtenPoint].position)));
        if (Vector3.Distance(transform.position,points[currtenPoint].position)<0.1f)
        {
            if (currtenPoint>=4)
            {
                currtenPoint = 1;
            }
            else
            {
                currtenPoint++;
            }

            if (currtenPoint==4)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
            }
            else
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, (currtenPoint-2) * 90));
                if (currtenPoint==1||currtenPoint==3)
                {
                    transform.localScale = new Vector3(0.5f, -0.5f, 0.5f);
                }
                else
                {
                    transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
            }
        }
    }
}


