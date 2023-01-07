using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryScript : MonoBehaviour
{
    
    private Collider2D coll;
    
    private SpriteRenderer sr;

    
    private void Start() {
        
       sr = GetComponent<SpriteRenderer>();
       coll = GetComponent<Collider2D>();
    }
    
    
    
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Wait());
        }

        
    }

    

    IEnumerator Wait(){
        CherryScale();
        yield return new WaitForSeconds(5);
        sr.enabled = true;
        coll.enabled = true;

        
    }

    private void CherryScale(){
        sr.enabled = false;
        coll.enabled = false;
        

    }
   

   
}
