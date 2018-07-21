using System;

[Serializable]
public class StartMarker{
    public float latitude;
    public float longitude;
    public string name;
    public int id;
    public Array quests;

    public String getLatLong()
    {
        return latitude.ToString() + "," + longitude.ToString();
    }
}
