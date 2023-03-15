using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmameterAnimationController : MonoBehaviour
{
    public Animator ArmameterAnim;


    private void Start()
    {
        ArmameterAnim = GetComponent<Animator>();
    }
    private void Update()
    {

    }
    public void OpenArma()
    {
        if (ArmameterAnim.GetBool("ArmaOpen") != true)
        {
            ArmameterAnim.SetBool("ArmaOpen", true);
        }
        else
        {
            ArmameterAnim.SetBool("ArmaOpen", false);
        }
    }
}
