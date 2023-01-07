using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GemScriptt
{
public class GemScript : MonoBehaviour
{
    public static int score;
    private void OnTriggerEnter2D(Collider2D other)
     {
        if(other.gameObject.CompareTag("Player")){
            Destroy(gameObject);
            score++;
        }
    }
}
}
