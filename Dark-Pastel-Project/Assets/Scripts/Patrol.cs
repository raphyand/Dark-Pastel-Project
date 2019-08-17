﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
     public Transform[] moveSpots;
     private int randomSpot;

     [SerializeField] private float speed;
     [SerializeField] private float waitTime;
     [SerializeField] private float startWaitTime;

    // Start is called before the first frame update
    void Start()
    {
          waitTime = startWaitTime;
          randomSpot = Random.Range(0, moveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
          PatrolByNodes();
    }

     void PatrolByNodes()
     {
          transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
          if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
          {
               if (waitTime <= 0)
               {
                    randomSpot = Random.Range(0, moveSpots.Length);
                    waitTime = startWaitTime;
               }
               else
               {
                    waitTime -= Time.deltaTime;
               }
          }


     }
}
