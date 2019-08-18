using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
     public float speed;
     private Transform player;
     private Vector2 target;
     private Rigidbody2D projectileRB;
     [SerializeField] private Animator anim;


     void OnTriggerEnter2D(Collider2D collision)
     {
          //transform.position = Vector2.zero;
          projectileRB.velocity = Vector2.zero;
          projectileRB.Sleep();
          DissipateAnimation();


          //transform.position = new Vector2(0, 0);
          //if (other.CompareTag("Player"))
          //{
          //   DestroyProjectile();
          //}
     }

     void Start()
     {
          player = GameObject.FindGameObjectWithTag("Player").transform;
          target = new Vector2(player.position.x, player.position.y);
          anim = GetComponent<Animator>();
          projectileRB = GetComponent<Rigidbody2D>();
     }

     void Update()
     {
          transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

          if (transform.position.x == target.x && transform.position.y == target.y)
          {
               ////DestroyProjectile();
               DissipateAnimation();
          }
          


     }
     






     void DissipateAnimation()
     {
          anim.Play("Fireball_Dissipate");
     }

     void DestroyProjectile()
     {
          Destroy(gameObject);
     }


}
