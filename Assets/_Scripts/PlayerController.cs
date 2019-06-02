using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 500f;
    float movement = 0f;
    public Animator anim;
    public GameManager gameManager;

    float deltaX;
    float xPos;

    private void Update()
    {
        xPos = Input.GetAxis("Mouse X");
        if (Input.touchCount > 0)
        {
            xPos = Input.touches[0].deltaPosition.x;
        }
        movement = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, xPos * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            FindObjectOfType<AudioManager>().Play("Out");
            anim.SetTrigger("isDestroyed");
            Destroy(this.gameObject, 2);
            GameManager.score -= 1;
            gameManager.GameOver();
        }
        if (collision.gameObject.tag == "Point")
        {
            FindObjectOfType<AudioManager>().Play("Out");
            GameManager.score += 1;
        }
    }
}
