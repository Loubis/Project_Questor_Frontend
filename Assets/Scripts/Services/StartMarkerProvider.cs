using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMarkerProvider : MonoBehaviour {

    private string url = "http://localhost:8080/startMarkers";

    private string jsonString;
    private StartMarkerCollection startMarkerCollection;

    IEnumerator getData()
    {
        WWW request = new WWW(url);
        yield return request;
        jsonString = "{\"startMarkers\":" + request.text + "}";
        Debug.Log(jsonString);
        startMarkerCollection = JsonUtility.FromJson<StartMarkerCollection>(jsonString);
        Debug.Log("Markers: " + startMarkerCollection.startMarkers.Length);
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(getData());
	}
}
