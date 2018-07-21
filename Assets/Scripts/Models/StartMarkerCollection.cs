using System;
[Serializable]
public class StartMarkerCollection{
    public StartMarker[] startMarkers;

    public String[] getCoordinates()
    {
        int i = 0;
        String[] result = new String[startMarkers.Length];
        foreach(StartMarker sm in startMarkers)
        {
            result[i] = sm.getLatLong();
            i++;
        }
        return result;
    }
}
