using UnityEngine;

namespace Controller
{
    public class StartQuestController : MonoBehaviour
    {

        public GameObject questMarkerPrefab;
        
        public void startQuest()
        {
            GameObject qm = Instantiate(questMarkerPrefab);
            qm.GetComponent<QuestMarkerModel>().questmarker =
                GetComponent<StartmarkerModel>().startMarker.quests[0].startPosition;
        }
    }
}