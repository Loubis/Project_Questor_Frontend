using System;
using System.Collections.Generic;

[Serializable]
public class StartMarker{
    public float latitude;
    public float longitude;
    public string name;
    public int id;
    public List<Quest> quests;

    public String getLatLong()
    {
        return latitude.ToString() + "," + longitude.ToString();
    }
}
