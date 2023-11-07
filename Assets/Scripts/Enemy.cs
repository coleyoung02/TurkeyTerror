using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private State state;
    private GameObject turkey;
    private NavMeshAgent agent;
    [SerializeField]
    private List<GameObject> patrolPoints;

    void Start()
    {
        turkey = FindAnyObjectByType<PlayerMovement>().gameObject;
        agent = GetComponent<NavMeshAgent>();
        state = new Patrol(this, patrolPoints, 0);
    }

    public void SpotTurkey()
    {
        state.SpotTurkey();
    }

    public Vector3 GetTurkeyLocation()
    {
        return turkey.transform.position;
    }

    public NavMeshAgent GetAgent()
    {
        return agent;
    }

    private void Update()
    {
        state = state.OnUpdate();
    }
}
