using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StartMarkerController : MonoBehaviour {

    public GameObject startMarkerPrefab;

    public void generateStartMarker(StartMarker[] startMarkers)
    {
        int i = 1;
        foreach(StartMarker startMarker in startMarkers)
        {
            GameObject smObj = Instantiate(startMarkerPrefab);
            smObj.name = "StartMarker" + i;
            i++;
            Questmarker qm = smObj.GetComponentInChildren<Questmarker>();
            qm.latitude = startMarker.latitude;
            qm.longitude = startMarker.longitude;
            Text[] text = smObj.GetComponentsInChildren<Text>(true);
            text[2].text = startMarker.name;
        }
    }

}
