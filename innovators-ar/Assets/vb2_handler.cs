using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class vb2_handler : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vb2obj;
    public GameObject desc_plane;
    public GameObject desc_title;
    public GameObject desc_text;
    // Start is called before the first frame update
    void Start()
    {
        vb2obj = GameObject.Find("VirtualButton2");
        desc_plane = GameObject.Find("Description_plane");
        vb2obj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        desc_title.GetComponent<TextMesh>().text = "substage 2";
        desc_text.GetComponent<TextMesh>().text = "in this stage...";
        desc_plane.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        desc_plane.SetActive(false);
    }
}
