using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class vb2_handler : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vb2obj;
    public Transform target_text;
    public Transform panel_text;
    // Start is called before the first frame update
    void Start()
    {
        vb2obj = GameObject.Find("VirtualButton2");
        vb2obj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        target_text.GetComponent<Text>().text = "substage 2";
        panel_text.GetComponent<Text>().text = "in this stage...";
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        target_text.GetComponent<Text>().text = "substage xxx";
        panel_text.GetComponent<Text>().text = "xxx";
    }
}
