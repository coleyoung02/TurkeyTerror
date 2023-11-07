using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : State
{
    private static float spinRate = 60f; // spin rate in degrees per second
    private float accumulatedSpin; // degrees spun around y axis so far 
    public Spin(Enemy enemy, List<GameObject> patrolPoints, int patrolIndex) : base(enemy, patrolPoints, patrolIndex)
    {
        accumulatedSpin = enemy.gameObject.transform.rotation.y;
    }

    public override Vector3 GetDestination()
    {
        return enemy.transform.position;
    }

    public override State OnUpdate()
    {
        float frameAngle = Time.deltaTime * spinRate;
        accumulatedSpin += frameAngle;
        enemy.gameObject.transform.Rotate(0, 0, frameAngle, Space.Self);
        if (accumulatedSpin >= 360f)
        {
            nextState = new Patrol(enemy, patrolPoints, patrolIndex);
        }
        return base.OnUpdate();
    }
}
