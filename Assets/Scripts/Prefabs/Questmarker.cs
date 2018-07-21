using System.Collections;
using System.Collections.Generic;
using Mapbox.Unity.Location;
using Mapbox.Utils;
using UnityEngine;

public class Questmarker : MonoBehaviour {

	bool _isInitialized;
	public double longitude;
	public double latitude;
	
	void Start()
	{
		LocationProviderFactory.Instance.mapManager.OnInitialized += () => _isInitialized = true;
	}

	void LateUpdate()
	{
		if (_isInitialized)
		{
			var map = LocationProviderFactory.Instance.mapManager;
			transform.localPosition = map.GeoToWorldPosition(new Vector2d(longitude, latitude));
		}
	}
}
