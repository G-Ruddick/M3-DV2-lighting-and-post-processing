using UnityEngine;

public class circlemove : MonoBehaviour
{
    public Transform target;
    public float speed;
    public float radius;
    public float angle;

    void Start() {
        speed = 0.8f;
        radius = 0.01f;
        angle = 0f;
    }

    void Update()
    {
        float x = target.position.x + radius * Mathf.Cos(angle);
        float y = target.position.y;
        float z = target.position.z + radius * Mathf.Sin(angle);

        transform.position = new Vector3(x,y,z);

        angle += speed * Time.deltaTime;
    }
}
