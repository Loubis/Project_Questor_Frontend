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
            StartmarkerModel qm = smObj.GetComponentInChildren<StartmarkerModel>();
            qm.latitude = startMarker.latitude;
            qm.longitude = startMarker.longitude;
            qm.startMarker = startMarker;
            Text[] text = smObj.GetComponentsInChildren<Text>(true);
            text[2].text = startMarker.name;
            foreach (Quest quest in startMarker.quests)
            {
                text[2].text += "\n" + quest.setting;
            }
            
        }
    }

}
