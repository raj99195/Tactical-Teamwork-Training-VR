using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LendGearTopPopUpUIControls : MonoBehaviour
{
    public GameObject wheelObject;

    public void Start()
    {
        wheelObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "FrontWheel")
        {
            wheelObject.SetActive(true);
        }
        else
        {
            wheelObject.SetActive(false);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        wheelObject.SetActive(false);
    }
}
