using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryAnimationController : MonoBehaviour
{
    public Animator canopyAnim;


    private void Start()
    {
        canopyAnim = GetComponent<Animator>();
    }
    private void Update()
    {

    }
    public void OpenBatteryBox()
    {
        if (canopyAnim.GetBool("OpenBattery") != true)
        {
            canopyAnim.SetBool("OpenBattery", true);
        }
        else
        {
            canopyAnim.SetBool("OpenBattery", false);
        }
    }
}
