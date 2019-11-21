using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Vuforia
{
    public class target_data : MonoBehaviour
    {
        public Transform target_text;
        public Transform panel_text;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;

                Debug.Log("image name: " + name);


                target_text.gameObject.SetActive(true);
                panel_text.gameObject.SetActive(true);

                //target_text.GetComponent<Text>().text = name;
                if (name == "stage_1")
                {
                    target_text.GetComponent<Text>().text = "Stage 1";
                    panel_text.GetComponent<Text>().text = "this is stage 1 where the initial...";
                }

                if (name == "stage_2")
                {
                    target_text.GetComponent<Text>().text = "Stage 2";
                    panel_text.GetComponent<Text>().text = "this is stage 2 where the process...";
                }

            }
        }
    }
}