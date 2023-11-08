using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pickup : MonoBehaviour
{
    private static int pickedUp = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Turkey"))
        {
            pickedUp++;
            gameObject.SetActive(false);
        }
    }

    private void OnDisable()
    {
        if (pickedUp == 4)
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
