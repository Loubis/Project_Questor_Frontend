using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleMapsAPI : MonoBehaviour
{

    string url;
    public RawImage img;

    LocationInfo li;

    public int zoom = 14;
    public int mapWidth = 640;
    public int mapHeight = 640;

    public enum mapType { roadmap, satellite, hybrid, terrain }
    public mapType mapSelected;
    public int scale;

    IEnumerator Map()
    {
        float lat = GPS.Instance.lat;
        float lng = GPS.Instance.lng;

        url = "https://maps.googleapis.com/maps/api/staticmap?center=" + lat + "," + lng +
            "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale
            + "&maptype=" + mapSelected + "&markers=color:blue%7Clabel:S%7C" + lat + "," + lng + "&key=AIzaSyDqCjII5YABMxpueTxa0Ao4VH6E8MsYN2E";
        WWW www = new WWW(url);
        yield return www;
        img.texture = www.texture;
        //img.SetNativeSize();
        ImageScaler.SizeImgToParent(img);
    }
    // Use this for initialization
    void Start()
    {
        img = gameObject.GetComponent<RawImage>();
        StartCoroutine(Map());
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Map());
    }
}
