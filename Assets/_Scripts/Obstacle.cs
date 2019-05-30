using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float rotateSpeed;

    Vector3 increment;
    [HideInInspector]
    public int decider;

    private void Start()
    {
        increment = new Vector3(0.001f, 0.001f, 0f);
        transform.localScale = Vector3.one * 0.0f;
        decider = Random.Range(1,3);
    }
    private void Update()
    {
        transform.localScale += increment;
        increment.x += 0.0001f;
        increment.y += 0.0001f;
        if(decider==1)
            transform.Rotate(Vector3.forward * rotateSpeed*Time.deltaTime);
        else
            transform.Rotate(Vector3.forward * -rotateSpeed * Time.deltaTime);
        destroyObstacle();
    }

    public void destroyObstacle()
    {
        if (this.transform.localScale.x > 4.0)
            Destroy(this.gameObject);
    }
}
