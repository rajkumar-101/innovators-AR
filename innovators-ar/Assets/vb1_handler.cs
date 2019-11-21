using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class vb1_handler : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject vb1obj;
    public GameObject desc_plane;
    public GameObject desc_title;
    public GameObject desc_text;
    // Start is called before the first frame update
    void Start()
    {
        vb1obj = GameObject.Find("VirtualButton1");
        desc_plane = GameObject.Find("Description_plane");
        vb1obj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        desc_title.GetComponent<TextMesh>().text = "substage 1";
        desc_text.GetComponent<TextMesh>().text = "in this stage...";
        desc_plane.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        desc_plane.SetActive(false);
    }
}
