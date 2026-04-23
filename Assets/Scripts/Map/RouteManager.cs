using UnityEngine;
using System.Collections.Generic;

public class RouteManager : MonoBehaviour {
    [System.Serializable]
    public class BusRoute {
        public string routeName;
        public List<Transform> waypoints = new List<Transform>();
        public List<string> stops = new List<string>();
    }

    [SerializeField] private List<BusRoute> routes = new List<BusRoute>();
    [SerializeField] private int currentRouteIndex = 0;
    [SerializeField] private int currentWaypointIndex = 0;

    private BusRoute currentRoute;

    private void Start() {
        if (routes.Count > 0) {
            SetRoute(0);
        }
    }

    public void SetRoute(int routeIndex) {
        if (routeIndex >= 0 && routeIndex < routes.Count) {
            currentRouteIndex = routeIndex;
            currentRoute = routes[routeIndex];
            currentWaypointIndex = 0;
        }
    }

    public Transform GetNextWaypoint() {
        if (currentRoute != null && currentRoute.waypoints.Count > 0) {
            return currentRoute.waypoints[currentWaypointIndex];
        }
        return null;
    }

    public void AdvanceWaypoint() {
        if (currentRoute != null && currentRoute.waypoints.Count > 0) {
            currentWaypointIndex = (currentWaypointIndex + 1) % currentRoute.waypoints.Count;
        }
    }

    public string GetCurrentRouteName() => currentRoute != null ? currentRoute.routeName : "No Route";

    public string GetCurrentStop() => currentRoute != null && currentWaypointIndex < currentRoute.stops.Count ? currentRoute.stops[currentWaypointIndex] : "Unknown";

    public string GetNextStop() => currentRoute != null && (currentWaypointIndex + 1) < currentRoute.stops.Count ? currentRoute.stops[currentWaypointIndex + 1] : "End of Route";
}