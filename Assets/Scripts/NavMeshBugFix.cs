using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshBugFix : MonoBehaviour
{

    UnityEngine.AI.NavMeshAgent agent;
    // Sets the navmesh agents rotation and axis updates to false to ensure that extraneous variables do not affect movement
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
}