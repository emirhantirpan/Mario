using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerMovementNameSpace
{

public class PlayerMovement : MonoBehaviour
{
   public static float jumpPower = 5f;
   [SerializeField] GameObject Camera;
   Vector3 cameraDistance;
   [SerializeField] private float speed = 5f;
   [SerializeField] public float CherryEffectTime = 5;
   Rigidbody2D rb;
   private bool isGrounded = false;
   public Game_Manager gm;
   
   
   private void Start() 
   {
      
      rb = GetComponent<Rigidbody2D>();
      GameObject.Find("Main Camera");

   }
   private void Update() 
   {
     CharacterMovement();
     SpriteRotation();
     Camera.transform.position = new Vector3(transform.position.x + cameraDistance.x , transform.position.y + cameraDistance.y, (transform.position.z + cameraDistance.z)-1);
     
   }

   private void SpriteRotation()
   {
    
     if(Input.GetKeyDown(KeyCode.LeftArrow)){
        transform.localRotation = Quaternion.Euler(0, 180, 0);



     }
     else if(Input.GetKeyDown(KeyCode.RightArrow)){
        transform.localRotation = Quaternion.Euler(0, 0, 0);

     }
    

   }
   public void CharacterMovement()
   {
     
     
      var movement = Input.GetAxis("Horizontal");
      
      transform.position += new Vector3(movement , 0 , 0) * Time.deltaTime * speed;




     if(Input.GetKeyDown(KeyCode.Space) == true && isGrounded == true)
     {
        rb.velocity = new Vector2 (0 , jumpPower);
        isGrounded = false;
     }

   }
   public void OnCollisionEnter2D(Collision2D other) 
   {
      if(other.gameObject.CompareTag("JumpableGround"))
      {
         isGrounded = true;

      }
      if(other.gameObject.CompareTag("Enemy"))
      {
         gm.health --;
      }
      
   
   }
   private void OnTriggerEnter2D(Collider2D other) 
   {
      if(other.gameObject.CompareTag("next_level"))
      {
         SceneManager.LoadScene("level2");
         
      }
      if(other.gameObject.CompareTag("next_level2"))
      {
         SceneManager.LoadScene("level3");
         
      }
      if(other.gameObject.CompareTag("next_level3"))
      {
         SceneManager.LoadScene("level4");
         
      }
      if(other.gameObject.CompareTag("finish"))
      {
         SceneManager.LoadScene("Finish");
         
         
      }
      if(other.gameObject.CompareTag("dead"))
      {
         gm._deathPanel.SetActive(true);
         Time.timeScale = 1;
      }
      if(other.gameObject.CompareTag("Enemy"))
      {
         gm.health --;
      }
      
   }
}
}
