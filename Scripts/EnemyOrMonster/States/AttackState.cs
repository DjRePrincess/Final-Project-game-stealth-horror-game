using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : BaseState
{
    private float moveTimer;
    private float losePlayerTimer;
    public float waitBeforeSearchTime = 8;
    public override void Enter()
    {
        // instead of bullets, monster needs to start chasing the player 
        // maybe like the dog in lethal company the movement is on a straight line, can crash into walls, stunning the monster 
        // if the monster catches up to the player then ofc perma death, game over, start screen again 

        // i guess the monster has to be faster each time (each stun?) to catch up on the player 
        // take note on where the player went to catch up on it 

        // if player hides and the mosnter didnt caught this in the act, after few seconds then move back into hunting phase 
        // if the mosnter sees the player in the act of hiding then just stomp over there and kill the player 

        // or maybe like theres low level enemies like simple enemies 
        // and the player just has to sneak by  them 
        // giving one of those 

        // chase(), stunIntoTheWall()
        // if monster touches the player take dmg 100 (player have 100 health) (or just game over all together)
    }


    
    public override void Perform()
    {
        if (enemy.CanSeePlayer())
        {
            losePlayerTimer = 0;
            moveTimer += Time.deltaTime;
            // makes the enemy lock onto looking at the enemy player 
            enemy.transform.LookAt(enemy.Player.transform);
            if (moveTimer > Random.Range(3, 7))
            {
                enemy.Agent.SetDestination(enemy.transform.position + (Random.insideUnitSphere * 5));
                moveTimer = 0;
            }
            enemy.LastKnowPos = enemy.Player.transform.position;
        }
        else // loses sight of player 
        {
            losePlayerTimer += Time.deltaTime;

            if (losePlayerTimer > waitBeforeSearchTime)
            {
                // change to search state 
                stateMachine.ChangeState(new SearchState());
            }
        }
    }

   
    public override void Exit()
    {

    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
