using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private State state;
    private GameObject turkey;

    void Start()
    {
        turkey = FindAnyObjectByType<PlayerMovement>().gameObject;
    }

    public void SpotTurkey()
    {
        state.SpotTurkey();
    }

    public Vector3 GetTurkeyLocation()
    {
        return turkey.transform.position;
    }
}
