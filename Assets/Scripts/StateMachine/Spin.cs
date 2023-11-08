using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : State
{
    // TODO: spin the enemy a full 360 degrees, and then make the right state change
    // also, think about what the destination should be for the spin state...

    // the Transform.Rotate() function may be useful to actually do the rotation https://docs.unity3d.com/ScriptReference/Transform.Rotate.html
    
    private static float spinRate = 60f; // spin rate in degrees per second

    public Spin(Enemy enemy, List<GameObject> patrolPoints, int patrolIndex) : base(enemy, patrolPoints, patrolIndex)
    {
    }

    public override Vector3 GetDestination()
    {
        throw new System.NotImplementedException();
    }
}
