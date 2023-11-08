using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Turkey"))
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (FindObjectsByType<Pickup>(FindObjectsSortMode.InstanceID).Length <= 0)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
