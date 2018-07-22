using Mapbox.Unity.Location;
using Mapbox.Utils;
using Models;
using UnityEngine;

namespace Controller
{
    public class QuestMarkerModel : MonoBehaviour
    {
        public Questmarker questmarker;

        private void LateUpdate()
        {
            if (questmarker != null)
            {
                var map = LocationProviderFactory.Instance.mapManager;
                transform.localPosition =
                    map.GeoToWorldPosition(new Vector2d(questmarker.longitude, questmarker.latitude));
            }
        }
    }
}