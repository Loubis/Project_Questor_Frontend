using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMarkerProvider : MonoBehaviour {

    private string url = "http://localhost:8080/startMarkers";

    private string jsonString;
    private StartMarkerCollection startMarkerCollection;

    IEnumerator getData()
    {
        WWW request = new WWW(url);
        yield return request;
        jsonString = "{\"startMarkers\":" + request.text + "}";
	    //jsonString = "{\"startMarkers\":[{\"latitude\": 24.96693,\"longitude\": 60.19179,\"name\": \"StartMarker1\",\"id\": 1,\"quests\": []},{\"latitude\": 24.96750,\"longitude\": 60.19130,\"name\": \"StartMarker2\",\"id\": 2,\"quests\": []},{\"latitude\": 7.44,\"longitude\": 51.53,\"name\": \"StartMarker3\",\"id\": 3,\"quests\": []},{\"latitude\": 7.45,\"longitude\": 51.52,\"name\": \"StartMarker4\",\"id\": 4,\"quests\": []},{\"latitude\": 7.46,\"longitude\": 51.54,\"name\": \"StartMarker5\",\"id\": 5,\"quests\": []}]}";
        Debug.Log(jsonString);
        startMarkerCollection = JsonUtility.FromJson<StartMarkerCollection>(jsonString);
        Debug.Log("Markers: " + startMarkerCollection.startMarkers.Length);
	    StartMarkerController startMarkerController = GetComponent<StartMarkerController>();
	    startMarkerController.generateStartMarker(startMarkerCollection.startMarkers);
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(getData());
	}
}
