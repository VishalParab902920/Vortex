using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 500f;
    float movement = 0f;
    public Animator anim;
    public GameManager gameManager;

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * speed * Time.fixedDeltaTime);
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
