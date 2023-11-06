using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementDir = new Vector2(0, 0);
        if (Input.GetKey("W"))
        {
            movementDir += new Vector2(0, 1);
        }
        if (Input.GetKey("A"))
        {
            movementDir += new Vector2(-1, 0);
        }
        if (Input.GetKey("S"))
        {
            movementDir += new Vector2(0, -1);
        }
        if (Input.GetKey("D"))
        {
            movementDir += new Vector2(1, 0);
        }

    }
}
