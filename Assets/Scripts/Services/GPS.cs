using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{

    public float lat;
    public float lng;

    public static GPS Instance { set; get; }

    private IEnumerator LocationService()
    {
        //unity docs code
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("User has not enabled GPS");
            yield break;
        }
        Input.location.Start();
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        if (maxWait <= 0)
        {
            Debug.Log("Timed Out");
            yield break;
        }
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("Unable to determine Location");
            yield break;
        }
        //unity docs code end
        lat = Input.location.lastData.latitude;
        lng = Input.location.lastData.longitude;
    }

    // Use this for initialization
    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(LocationService());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
