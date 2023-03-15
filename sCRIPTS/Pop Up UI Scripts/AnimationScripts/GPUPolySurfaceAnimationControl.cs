using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPUPolySurfaceAnimationControl : MonoBehaviour
{
    public Animator GPUAnim; //Object Name


    private void Start()
    {
        //Firstly get the Animator Component
        GPUAnim = GetComponent<Animator>();
    }


    public void OpenBatteryBox()
    {
        if (GPUAnim.GetBool("IsOpen") != true)
        {
            GPUAnim.SetBool("IsOpen", true);
        }
        else
        {
            GPUAnim.SetBool("IsOpen", false);
        }
    }
}
