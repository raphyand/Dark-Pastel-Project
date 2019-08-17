using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{

     public float speed = 5f;
     public Transform target;


     private float timeBetweenShots;
     public float startTimeBetweenShots;
     public GameObject projectile;



    // Start is called before the first frame update
    void Start()
    {
          timeBetweenShots = startTimeBetweenShots;
    }

    // Update is called once per frame
    void Update()
    {
          // target position minus origin position
          Vector2 direction = target.position - transform.position;
          float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
          Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
          transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
        
          if (timeBetweenShots <= 0)
          {
               // (what do we want to spawn, position, rotation)
               Instantiate(projectile, transform.position, transform.rotation/*Quaternion.identity*/);
               timeBetweenShots = startTimeBetweenShots;
          }
          else
          {
               timeBetweenShots -= Time.deltaTime;
          }


    }
}
