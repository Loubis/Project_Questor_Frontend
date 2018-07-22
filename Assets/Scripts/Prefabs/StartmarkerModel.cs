using System.Collections;
using System.Collections.Generic;
using Mapbox.Unity.Location;
using Mapbox.Utils;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartmarkerModel : MonoBehaviour
{
	public StartMarker startMarker;

    bool _isInitialized;
    public double longitude;
    public double latitude;

	public GameObject questPopUp;

    void LateUpdate()
    {
            var map = LocationProviderFactory.Instance.mapManager;
            transform.localPosition = map.GeoToWorldPosition(new Vector2d(longitude, latitude));
    }
    void OnMouseDown()
    {
		questPopUp.SetActive(true);
    }
}
