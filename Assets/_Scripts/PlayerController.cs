using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 500f;
    float movement = 0f;

    private void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * speed * Time.fixedDeltaTime);
    }
}
