using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Player2Controller : NetworkBehaviour
{
    private CharacterController controller;
    private float playerSpeed = 15.0f;
    private Animator pAnimator;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        pAnimator = GetComponent<Animator>();
        if (pAnimator == null)
        {
            Debug.LogError("Animator component not found!");
        }
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            pAnimator.SetBool("IsWalk", true);
            gameObject.transform.forward = move;
        }
        else
        {
            pAnimator.SetBool("IsWalk", false);
        }
    }
}
