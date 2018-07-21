using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoogleMapsAPI : MonoBehaviour {

    RawImage img;

    string url;

    public float latitude;
    public float longitude;

    LocationInfo li;

    public int zoom = 14;
    public int mapWidth = 1280;
    public int mapHeight = 1280;

    public enum mapType {roadmap, satellite, hybrid, terrain };
    public mapType mapSelected;
    public int scale;

    IEnumerator Map()
    {
        url = "https://maps.googleapis.com/maps/api/staticmap?center=" + latitude.ToString() + "," + longitude.ToString() +
            "&zoom=" + zoom + "&size=" + mapWidth + "x" + mapHeight + "&scale=" + scale
            + "&maptype=" + mapSelected +
            "&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Clabel:C%7C40.718217,-73.998284&key=AIzaSyDqCjII5YABMxpueTxa0Ao4VH6E8MsYN2E";
        WWW www = new WWW(url);
        yield return www;
        img.texture = www.texture;
        img.SetNativeSize();
    }
    
	// Use this for initialization
	void Start () {
        img = gameObject.GetComponent<RawImage>();
        // Get GPS location
        this.longitude = GPS.Instance.longitude;
        this.latitude = GPS.Instance.latitude;
        
        // Set map scale to screen width
        this.mapWidth = Screen.width;
        this.mapHeight = Screen.height;


        StartCoroutine(Map());
	}
	
	// Update is called once per frame
	void Update () {
        // Update GPS locations
		this.longitude = GPS.Instance.longitude;
        this.latitude = GPS.Instance.latitude;
	}
}
