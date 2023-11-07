using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : State
{

    public Chase(Enemy enemy, List<GameObject> patrolPoints, int patrolIndex) : base(enemy, patrolPoints, patrolIndex)
    {
        this.enemy = enemy;
        this.patrolPoints = patrolPoints;
    }

    public override Vector3 GetDestination()
    {
        return enemy.GetTurkeyLocation();
    }

    public override void SpotTurkey()
    {
        return;
    }
}
