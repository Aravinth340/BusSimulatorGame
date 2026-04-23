using UnityEngine;
using System.Collections;

public class TrafficRules : MonoBehaviour
{
    // Speed limit in kilometers per hour
    public float speedLimit = 50f;
    // Light states
    private enum LightState { Red, Yellow, Green };
    private LightState currentLightState;

    // Traffic light duration
    public float redLightDuration = 10f;
    public float greenLightDuration = 10f;
    public float yellowLightDuration = 3f;

    void Start()
    {
        currentLightState = LightState.Red;
        StartCoroutine(TrafficLightCycle());
    }

    // Coroutine to manage traffic light states
    private IEnumerator TrafficLightCycle()
    {
        while (true)
        {
            switch (currentLightState)
            {
                case LightState.Red:
                    yield return new WaitForSeconds(redLightDuration);
                    currentLightState = LightState.Green;
                    break;
                case LightState.Green:
                    yield return new WaitForSeconds(greenLightDuration);
                    currentLightState = LightState.Yellow;
                    break;
                case LightState.Yellow:
                    yield return new WaitForSeconds(yellowLightDuration);
                    currentLightState = LightState.Red;
                    break;
            }
        }
    }

    // Method to enforce speed limit
    public void CheckSpeed(float vehicleSpeed)
    {
        if (vehicleSpeed > speedLimit)
        {
            Debug.Log("Speeding! Please slow down.");
            // Implement logic for penalty or warning
        }
    }
}