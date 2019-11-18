using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loader : MonoBehaviour
{
    public Transform button_action;

    private void Awake()
    {
        button_action.GetComponent<Button>().onClick.AddListener(delegate { SceneManager.LoadScene("SampleScene"); });

    }
}
