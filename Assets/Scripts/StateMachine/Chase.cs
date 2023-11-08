using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : State
{
    // TODO: implement the get destination function for the chase state
    // note, this is not a monobehavior, but it does have a reference to Enemy should
    // have some functions that might be helpful to use

    public Chase(Enemy enemy, List<GameObject> patrolPoints, int patrolIndex) : base(enemy, patrolPoints, patrolIndex)
    {
    }

    public override Vector3 GetDestination()
    {
        throw new System.NotImplementedException();
    }

    //you might also want to change spot turkey so that we dont repeatedly enter this state over and over again
}
