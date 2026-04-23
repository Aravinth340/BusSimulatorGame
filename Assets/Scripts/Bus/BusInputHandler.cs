using UnityEngine;

public class BusInputHandler : MonoBehaviour
{
    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveBusForward();
        }
        if (Input.GetKey(KeyCode.S))
        {
            MoveBusBackward();
        }
        if (Input.GetKey(KeyCode.A))
        {
            TurnBusLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            TurnBusRight();
        }
        if (Input.GetKey(KeyCode.Space))
        {
            ApplyBrakes();
        }
    }

    private void MoveBusForward()
    {
        // Logic for moving bus forward
    }

    private void MoveBusBackward()
    {
        // Logic for moving bus backward
    }

    private void TurnBusLeft()
    {
        // Logic for turning bus left
    }

    private void TurnBusRight()
    {
        // Logic for turning bus right
    }

    private void ApplyBrakes()
    {
        // Logic for applying brakes
    }
}