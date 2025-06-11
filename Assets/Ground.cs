using NUnit.Framework;
using UnityEngine;

public class gROUND : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x < -2.6)
        {
           transform.position = new Vector2(1.99f, transform.position.y);
        }
        transform.position += Vector3.left * Time.deltaTime * 1.3f;
    }
}
