using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GemScriptt;

public class TextScript : MonoBehaviour
{
    
    [SerializeField] Text counter;
    

    private void Start() {
        counter.text = "";
    }
    private void Update() {

        counter.text = "" + GemScript.score;
        
    }
}
