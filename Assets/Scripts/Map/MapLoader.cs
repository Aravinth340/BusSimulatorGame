using UnityEngine;

public class MapLoader : MonoBehaviour {
    [System.Serializable]
    public class MapData {
        public string mapName;
        public string location;
        public GameObject mapPrefab;
        public Terrain terrain;
    }

    [SerializeField] private MapData[] availableMaps;
    [SerializeField] private int currentMapIndex = 0;
    private MapData currentMapData;

    private void Start() {
        if (availableMaps.Length > 0) {
            LoadMap(0);
        }
    }

    public void LoadMap(int mapIndex) {
        if (mapIndex >= 0 && mapIndex < availableMaps.Length) {
            if (currentMapData != null && currentMapData.mapPrefab != null) {
                Destroy(currentMapData.mapPrefab);
            }
            currentMapIndex = mapIndex;
            currentMapData = availableMaps[mapIndex];
            if (currentMapData.mapPrefab != null) {
                Instantiate(currentMapData.mapPrefab, transform.position, Quaternion.identity);
            }
            Debug.Log($"Loaded map: {currentMapData.mapName} ({currentMapData.location})");
        }
    }

    public string GetMapInfo() {
        if (currentMapData != null) {
            return $"Map: {currentMapData.mapName} | Location: {currentMapData.location}";
        }
        return "No map loaded";
    }

    public MapData GetCurrentMap() => currentMapData;
    public int GetMapCount() => availableMaps.Length;
}