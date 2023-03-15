using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHNavigationLight : MonoBehaviour
{
    public GameObject descriptionLHCanvas;
    public GameObject infoLHnavLightCanvas;



    public void Start()
    {
        descriptionLHCanvas.SetActive(false);
        infoLHnavLightCanvas.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "LHNavLight")
        {
            descriptionLHCanvas.SetActive(true);
            infoLHnavLightCanvas.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        descriptionLHCanvas.SetActive(false);
        infoLHnavLightCanvas.SetActive(false);
    }
}
