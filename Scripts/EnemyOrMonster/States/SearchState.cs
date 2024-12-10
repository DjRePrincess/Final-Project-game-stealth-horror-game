using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchState : BaseState
{
    private float searchTimer;
    private float moveTimer;
    private float howLongToSearch = 10f;
    public override void Enter()
    {
        // what to do when it first enters search state 
        enemy.Agent.SetDestination(enemy.LastKnowPos);
        // i think this actually takes care of the actual moving forward, and turning 


    }

    public override void Perform()
    {
        if (enemy.CanSeePlayer()) 
            stateMachine.ChangeState(new AttackState());

        if (enemy.Agent.remainingDistance < enemy.Agent.stoppingDistance)
        {
            searchTimer += Time.deltaTime;
            moveTimer += Time.deltaTime;
            if (moveTimer > Random.Range(3, 5))
            {
                enemy.Agent.SetDestination(enemy.transform.position + (Random.insideUnitSphere * 10));
                moveTimer = 0;
            }

            if (searchTimer > howLongToSearch)
            {
                stateMachine.ChangeState(new PatrolState());
            }
        }
    }

    public override void Exit()
    {
        
    }
}
