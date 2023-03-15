
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOPAnimatioController : MonoBehaviour
{
    public Animator GOPAnim; //Object Name


    private void Start()
    {
        //Firstly get the Animator Component
        GOPAnim = GetComponent<Animator>();
    }


    public void OpenBatteryBox()
    {
        if (GOPAnim.GetBool("IsOpen") != true)
        {
            GOPAnim.SetBool("IsOpen", true);
        }
        else
        {
            GOPAnim.SetBool("IsOpen", false);
        }
    }
}
