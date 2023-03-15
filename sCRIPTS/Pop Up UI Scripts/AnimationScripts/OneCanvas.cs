using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneCanvas : MonoBehaviour
{
    public Animator canopyAnim; //Object Name


    private void Start()
    {
        //Firstly get the Animator Component
        canopyAnim = GetComponent<Animator>();
    }
    

    public void OpenBatteryBox()
    {
        if (canopyAnim.GetBool("AnimationName") != true)
        {
            canopyAnim.SetBool("AnimationName", true);
        }
        else
        {
            canopyAnim.SetBool("AnimationName", false);
        }
    }
}
