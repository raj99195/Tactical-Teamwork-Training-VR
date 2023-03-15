using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RHNavigationLightControlCanvas : MonoBehaviour
{
    public GameObject descriptionRHCanvas;
    public GameObject infoRHnavLightCanvas;

    

    public void Start()
    {
        descriptionRHCanvas.SetActive(false);
        infoRHnavLightCanvas.SetActive(false);
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "RHNavLight")
        {
            descriptionRHCanvas.SetActive(true);
            infoRHnavLightCanvas.SetActive(true);
        }
        

    }
    private void OnTriggerExit(Collider other)
    {
        descriptionRHCanvas.SetActive(false);
        infoRHnavLightCanvas.SetActive(false);
    }
}
