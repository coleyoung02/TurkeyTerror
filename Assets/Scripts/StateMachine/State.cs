using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    // TODO: finish implementing the SpotTurkey function on line 30

    public enum AgentType
    {
        Chase,
        Patrol
    }

    protected List<GameObject> patrolPoints;
    protected Enemy enemy;
    protected State nextState;
    protected int patrolIndex;

    public State(Enemy enemy, List<GameObject> patrolPoints, int patrolIndex)
    {
        this.enemy = enemy;
        this.patrolPoints = patrolPoints;
        this.patrolIndex = patrolIndex;
        nextState = this;
    }

    public abstract Vector3 GetDestination();

    public virtual void SpotTurkey()
    {
        SetNavmesh((int)AgentType.Chase);
        // TODO: set the next state to the chase state (hint, assign to the next state variable)
    }

    public void SetNavmesh(int agentID)
    {
        enemy.GetAgent().agentTypeID = agentID;
    }

    public virtual State OnUpdate()
    {
        //setting the desitination every frame may not be optimal for 
        //every state that we have, but it does make the code more uniform for each state
        enemy.GetAgent().SetDestination(GetDestination());
        
        return nextState;
    }
}
