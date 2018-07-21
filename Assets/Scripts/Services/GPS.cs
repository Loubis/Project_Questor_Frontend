using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour {

    public static GPS Instance { get; set; }

    public float longitude;
    public float latitude;

    private void Start() 
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
    }
    
    IEnumerator StartLocationService()
    {
        /* Unity Docs https://docs.unity3d.com/ScriptReference/LocationService.Start.html START*/

        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield break;

        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Service didn't initialize in 20 seconds
        if (maxWait < 1)
        {
            print("Timed out");
            yield break;
        }

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            print("Unable to determine device location");
            yield break;
        }
        /* Unity Docs END*/

        this.longitude = Input.location.lastData.longitude;
        this.latitude = Input.location.lastData.latitude;
    }

}
