using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
public class Stage3_handler : DefaultTrackableEventHandler
{
    public GameObject desc_plane;
    // Start is called before the first frame update
    
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
            ButtonAction.gameObject.SetActive(false);
            target_text.gameObject.SetActive(false);
            panel.gameObject.SetActive(false);

            desc_plane.gameObject.SetActive(false);
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

            ButtonAction.gameObject.SetActive(false);
            target_text.gameObject.SetActive(false);
            panel.gameObject.SetActive(false);
        }
    }
}
