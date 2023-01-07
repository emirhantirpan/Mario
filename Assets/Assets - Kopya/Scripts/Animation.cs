using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Animation : MonoBehaviour
{
    Animator isRun;
    Animator isJump;
    Animator isFall;
    Animator isCrouch;

    private bool crouchtojump;


    private bool space;
    private bool holdingDownButton;
    private bool jumpWork;

    Animator isSpace;
    
    Rigidbody2D rb;
    
    

    
    void Awake()
    {
        isRun = GetComponent<Animator>();
        isJump = GetComponent<Animator>();
        isSpace = GetComponent<Animator>();
        isFall = GetComponent<Animator>();    
        isCrouch = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();    
    }

    
    
    private void Update()
    {

        if(Input.GetKey(KeyCode.Space)){
            space = true;
            isSpace.SetBool("IsSpace" , true);
            isRun.SetBool("IsRun" , false);
            isRun.SetBool("IsCrouch" ,false);

        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            
            holdingDownButton = true;
        }
        else if(Input.GetKeyUp(KeyCode.DownArrow)){
            holdingDownButton = false;
            
        }
        else if(holdingDownButton == true && Input.GetKey(KeyCode.Space) == false)
        {
            isCrouch.SetBool("IsCrouch" , true);
        }
        else if(holdingDownButton == false){
            isCrouch.SetBool("IsCrouch" , false);
        }

        
        
        
        
        if((Input.GetKey(KeyCode.LeftArrow) == true ||Input.GetKey(KeyCode.RightArrow) == true) && Input.GetKey(KeyCode.Space) == false)
        {
            isRun.SetBool("IsRun" , true);
        }
        
        else 
        {
            isRun.SetBool("IsRun" , false);
        }

        
        
        if(space == true && rb.velocity.y > 0 )
        {
            isJump.SetInteger("JumpOrFall" , 1);

        }
        else if(rb.velocity.y < 0 && isFall == true)
        {
            isJump.SetInteger("JumpOrFall" , -1);
            
        }
        else
        {
            isJump.SetInteger("JumpOrFall" , 0);

        }
        
       
    }
    private void OnCollisionEnter2D(Collision2D other)
    {

        if(other.gameObject.CompareTag("JumpableGround"))
        {
            isJump.SetInteger("JumpOrFall" , 0);
            isSpace.SetBool("IsSpace" , false);
            isFall.SetBool("IsFall" , false);
            space = false;

        }
        
    }

    
    



    
}
