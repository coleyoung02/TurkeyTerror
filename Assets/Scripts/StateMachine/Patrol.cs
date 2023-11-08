using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : State
{
    // TODO: implement the get destination function
    // make sure to get the right destination since there are multiple patrol points.
    // Also, figure out how to switch to the right state when you reach that destination

    public Patrol(Enemy enemy, List<GameObject> patrolPoints, int patrolIndex) : base (enemy, patrolPoints, patrolIndex)
    {
    }

    public override Vector3 GetDestination()
    {
        throw new System.NotImplementedException();
    }
}
