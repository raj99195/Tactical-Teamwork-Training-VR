using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderTextPopUpUI : MonoBehaviour
{
    public GameObject cylinderText;

    public void Start()
    {
        cylinderText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(this.gameObject.tag == "Cylinder")
        {
            cylinderText.SetActive(true);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        cylinderText.SetActive(false);
    }


}
