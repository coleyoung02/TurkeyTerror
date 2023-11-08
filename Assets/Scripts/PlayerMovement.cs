using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private AudioSource source;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movementDir = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            movementDir += new Vector2(0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementDir += new Vector2(-1, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movementDir += new Vector2(0, -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movementDir += new Vector2(1, 0);
        }
        rb.velocity = movementDir.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            source.Play();
            Time.timeScale = 0;
            StartCoroutine(lose());
        }
    }

    IEnumerator lose()
    {
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadSceneAsync("LoseScene");
    }
}
