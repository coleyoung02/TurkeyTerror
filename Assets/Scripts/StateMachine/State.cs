using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
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
        nextState = new Chase(enemy, patrolPoints, patrolIndex);
    }

    public void SetNavmesh(int agentID)
    {
        enemy.GetAgent().agentTypeID = agentID;
    }

    public virtual State OnUpdate()
    {
        enemy.GetAgent().SetDestination(GetDestination());
        
        return nextState;
    }
}
