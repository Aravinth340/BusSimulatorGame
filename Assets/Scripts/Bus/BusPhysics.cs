using UnityEngine;

public class BusPhysics : MonoBehaviour
{
    public float speed;
    public float acceleration;
    public float brakeForce;

    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            speed += acceleration * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            speed -= brakeForce * Time.deltaTime;
            speed = Mathf.Max(0, speed);
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}