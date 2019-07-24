using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
     [SerializeField] float moveSpeed = 10f;
     [SerializeField] float jumpSpeed = 5f;
     SpriteRenderer mySpriteRenderer;
     [SerializeField] Sprite pastel, dark;
     Animator myAnimator;
     [SerializeField] AnimatorControllerParameter pastelAnimator, darkAnimator;
     

     Rigidbody2D myRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
          myRigidbody2D = GetComponent<Rigidbody2D>();
          mySpriteRenderer = GetComponent<SpriteRenderer>();
          myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          MoveLeftRight();
          Jump();
          FlipSprite();
          SwitchBetweenDarkAndPastel();
    }

     private void MoveLeftRight()
     {
          float deltaX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
          var newXPos = myRigidbody2D.position.x + deltaX;
          myRigidbody2D.velocity = new Vector2(moveSpeed * deltaX, myRigidbody2D.velocity.y);
     }

     private void Jump()
     {
          if (Input.GetKeyDown(KeyCode.Space) == true){

               Vector2 jumpVelocityToAdd = new Vector2(0f, jumpSpeed);
               myRigidbody2D.velocity += jumpVelocityToAdd;
          }
     }

     private void FlipSprite()
     {
          bool playerHasHorizontalSpeed = Mathf.Abs(/*transform.position.x*/myRigidbody2D.velocity.x) > Mathf.Epsilon;
          if (playerHasHorizontalSpeed)
               transform.localScale = new Vector2(Mathf.Sign(myRigidbody2D.velocity.x), 1f);
     }


     public void SwitchBetweenDarkAndPastel()
     {
          if (mySpriteRenderer.sprite == pastel)
          {
               mySpriteRenderer.sprite = dark;
          }
          else if (mySpriteRenderer.sprite == dark)
               mySpriteRenderer.sprite = pastel;
          else
               mySpriteRenderer.sprite = pastel;



     }


}
