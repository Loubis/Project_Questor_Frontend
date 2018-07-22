using System.Linq;
using UnityEngine;

namespace Controller
{
    public class StartQuestController : MonoBehaviour
    {

        public GameObject questMarkerPrefab;
        
        public void startQuest()
        {
            GameObject qm = Instantiate(questMarkerPrefab);
            //qm.GetComponent<QuestMarkerModel>().questmarker =
            //    GetComponent<StartmarkerModel>().startMarker.quests.ToArray().First().startPosition;
            //Debug.Log(GetComponent<StartmarkerModel>().startMarker.quests.First().startPosition);
        }
    }
}