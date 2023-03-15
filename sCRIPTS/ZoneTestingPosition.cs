using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZoneTestingPosition : MonoBehaviour
{
    public GameObject Zone1;
    public Image ZoneImg;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ZoneImg.gameObject.SetActive(true);
        }
        
    }


}
