using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTextPopUpUI : MonoBehaviour
{
    public GameObject cubeText;

    public void Start()
    {
        cubeText.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject.tag == "CubeBoxPopUp")
        {
            cubeText.SetActive(true);
        }
        else
        {
            cubeText.SetActive(false);
        }



        
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    cubeText.SetActive(false);
    //}

}
