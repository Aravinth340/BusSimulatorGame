using UnityEngine;

public class Waypoint : MonoBehaviour {
    [SerializeField] private string waypointName;
    [SerializeField] private int waypointID;
    [SerializeField] private float stopDuration = 5f;
    [SerializeField] private int passengerPickupCount = 0;
    [SerializeField] private int passengerDropoffCount = 0;
    [SerializeField] private Vector3 busStopPosition;
    private bool isPlayerAtStop = false;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Bus")) {
            isPlayerAtStop = true;
            OnBusArrive();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Bus")) {
            isPlayerAtStop = false;
        }
    }

    private void OnBusArrive() {
        Debug.Log($"Bus arrived at: {waypointName}");
    }

    public (int pickup, int dropoff) GetPassengerData() {
        return (passengerPickupCount, passengerDropoffCount);
    }

    public string GetWaypointName() => waypointName;

    public int GetWaypointID() => waypointID;

    public float GetStopDuration() => stopDuration;

    public bool IsPlayerAtStop() => isPlayerAtStop;
}