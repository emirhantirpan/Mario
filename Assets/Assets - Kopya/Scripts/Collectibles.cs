using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerMovementNameSpace;
public class Collectibles : MonoBehaviour
{
    public GameObject sprite;
    private bool colll = true;
    public float CherryEffectTime = 5;
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Cherry") && colll == true)
        {
          StartCoroutine(CherrySizeEffect());
        }
    }

    IEnumerator CherrySizeEffect()
    {
        if(colll == true)
        {
         colll = false;
         PlayerMovement.jumpPower = PlayerMovement.jumpPower * 1.5f;
         transform.localScale = transform.localScale * 1.5f;
         yield return new WaitForSeconds(CherryEffectTime);
         transform.localScale = transform.localScale / 1.5f;
         PlayerMovement.jumpPower = PlayerMovement.jumpPower / 1.5f;
         colll = true;

        }

        
    }

   

    
   


    
}
