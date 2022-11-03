using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;
    float horinzontalMove = 0f;

    // Update is called once per frame
    void Update()
    {
        horinzontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horinzontalMove));
    }

    void FixedUpdate()
    {
        // To move the character - "false, false" disables crouch and jump features from CharacterController 2D
        controller.Move(horinzontalMove * Time.fixedDeltaTime, false, false);
    }
}
