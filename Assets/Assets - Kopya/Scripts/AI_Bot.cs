using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;
public class AI_Bot : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed = 3;
    float distance;
    void Update()
    {
        distance = Vector2. Distance(transform.position, player. transform.position);
        Vector2 direction = player. transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player. transform.position, speed * Time.deltaTime);
    }
    
}
