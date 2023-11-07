using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : State
{

    public Patrol(Enemy enemy, List<GameObject> patrolPoints, int patrolIndex) : base (enemy, patrolPoints, patrolIndex)
    {
    }

    public override Vector3 GetDestination()
    {
        return patrolPoints[patrolIndex].transform.position;
    }


    public override State OnUpdate()
    {
        Vector2 v = enemy.gameObject.transform.position - patrolPoints[patrolIndex].transform.position;
        if ((v).magnitude < .01f)
        {
            nextState = new Spin(enemy, patrolPoints, (patrolIndex + 1) % patrolPoints.Count);
        }
        return base.OnUpdate();
    }
}
