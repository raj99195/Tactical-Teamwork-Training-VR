using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class CapsuleTextPopUpUI : MonoBehaviour
{
    public GameObject capsuleText;

    public void Start()
    {
        capsuleText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        capsuleText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        capsuleText.SetActive(false);
    }

   
    
}
