using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private StateMachine stateMachine;
    private NavMeshAgent agent;
    private GameObject player;
    private Vector3 lastKnowPos;
    public NavMeshAgent Agent { get => agent; }
    public GameObject Player { get => player; }
    public Vector3 LastKnowPos { get => lastKnowPos; set => lastKnowPos = value; }

    public Paths path;
    public GameObject debugsphere;


    [Header("Sight Values")]
    public float monsterSightDistance = 20f;
    public float fieldOfView = 85f;
    public float eyeHeight; // no need because our monster right now is small 

    //[Header("Weapon Values")]  no gun for monster 
    // debugging purposes 
    [SerializeField]
    private string currentState;

    void Start()
    {
        stateMachine = GetComponent<StateMachine>();
        agent = GetComponent<NavMeshAgent>();
        stateMachine.Initialize();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        CanSeePlayer();
        currentState = stateMachine.activeState.ToString();
        debugsphere.transform.position = lastKnowPos;
    }
    public bool CanSeePlayer()
    {
        if (player != null)
        {
            // is player close enough to be seen 
            if (Vector3.Distance(transform.position, player.transform.position) < monsterSightDistance)
            {
                Vector3 targetDirection = player.transform.position - transform.position - (Vector3.up * eyeHeight);
                float angleToPlayer = Vector3.Angle(targetDirection, transform.forward);
                // field of view value it's like a fan, negative and positive value 
                if (angleToPlayer >= -fieldOfView && angleToPlayer <= fieldOfView)
                {
                    Ray ray = new Ray(transform.position + (Vector3.up * eyeHeight), targetDirection);
                    RaycastHit hitInfo = new RaycastHit();
                    if (Physics.Raycast(ray, out hitInfo, monsterSightDistance))
                    {
                        if (hitInfo.transform.gameObject == player)
                        {
                            Debug.DrawRay(ray.origin, ray.direction * monsterSightDistance);
                            return true;
                        }
                    }
                }
            }
        }
        return false;
    }
}
