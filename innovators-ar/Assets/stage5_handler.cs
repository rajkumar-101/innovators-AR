using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;

public class stage5_handler : DefaultTrackableEventHandler
{
    // Start is called before the first frame update
    public GameObject console_model;
    public Animator console_ani;


    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnTrackingFound()
    {
        if (mTrackableBehaviour)
        {

            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);
            initial_text.gameObject.SetActive(false);
            console_anim_btn.gameObject.SetActive(true);


            target_text.gameObject.SetActive(true);
            panel.gameObject.SetActive(true);
            panel_text.GetComponent<Text>().text = "press button to animate";
            target_text.GetComponent<Text>().text = "Stage 5";
            console_anim_btn.GetComponent<Button>().onClick.AddListener(delegate { console_ani.Play("console_model_anim"); });

            console_model.gameObject.SetActive(true);
            // Enable rendering:
            foreach (var component in rendererComponents)
                component.enabled = true;

            // Enable colliders:
            foreach (var component in colliderComponents)
                component.enabled = true;

            // Enable canvas':
            foreach (var component in canvasComponents)
                component.enabled = true;



        }
    }

    protected override void OnTrackingLost()
    {
        if (mTrackableBehaviour)
        {
            var rendererComponents = mTrackableBehaviour.GetComponentsInChildren<Renderer>(true);
            var colliderComponents = mTrackableBehaviour.GetComponentsInChildren<Collider>(true);
            var canvasComponents = mTrackableBehaviour.GetComponentsInChildren<Canvas>(true);
            initial_text.gameObject.SetActive(true);
            // Disable rendering:
            foreach (var component in rendererComponents)
                component.enabled = false;

            // Disable colliders:
            foreach (var component in colliderComponents)
                component.enabled = false;

            // Disable canvas':
            foreach (var component in canvasComponents)
                component.enabled = false;

            console_model.gameObject.SetActive(false);
            console_anim_btn.gameObject.SetActive(false);
            target_text.gameObject.SetActive(false);
            panel.gameObject.SetActive(false);
        }
    }
}
