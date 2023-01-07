using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_TakeDamage : MonoBehaviour
{
    [SerializeField] GameObject pig;
    public Game_Manager gm;
    
    private void OnCollisionEnter2D(Collision2D col)
    {   
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(pig);
        }
    }
    
}
