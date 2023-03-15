using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAllAnimations : MonoBehaviour
{
    public Animator canopyAnim;
   
   
    private void Start()
    {
        canopyAnim = GetComponent<Animator>();
       
    }
    private void Update()
    {
        
    }
    public void OpenCanopy()
    {
        if (canopyAnim.GetBool("OpenBox") != true)
        {
            canopyAnim.SetBool("OpenBox", true);
        }
        else
        {
            canopyAnim.SetBool("OpenBox", false);
        }
    }
}
