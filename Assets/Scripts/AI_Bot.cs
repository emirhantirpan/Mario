using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class AI_Bot : MonoBehaviour
{
    NavMeshAgent bot;
    [SerializeField] Transform target;
    [SerializeField] float lookDistance = 5f;
    [SerializeField] private Player _player;
    void Start()
    {
        bot = GetComponent<NavMeshAgent>();
        bot.speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, target.position);
        bot.SetDestination(target.position);

        if (distance <= lookDistance)
        {
            bot.speed = 10f;
            
        }
        else
        {
            bot.speed = 5f;
        }
    }
}
