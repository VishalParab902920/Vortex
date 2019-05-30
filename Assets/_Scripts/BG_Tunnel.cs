using UnityEngine;

public class BG_Tunnel : MonoBehaviour
{
    Vector3 increment;

    private void Start()
    {
        increment = new Vector3(0.001f, 0.001f, 0f);
        transform.localScale = Vector3.one * 0.0f;
    }

    private void Update()
    {
        transform.localScale += increment;
        increment.x += 0.0001f;
        increment.y += 0.0001f;
        destroyObstacle();
    }

    public void destroyObstacle()
    {
        if (this.transform.localScale.x > 4.0)
            Destroy(this.gameObject);
    }
}
