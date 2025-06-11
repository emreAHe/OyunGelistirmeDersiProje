using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private float speed;
    void Start()
    {
        speed = 1.3f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * speed;
    }
}
