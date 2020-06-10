using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Animator animator;

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrouded;

    void start(){

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        isGrouded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        animator.SetBool("Mendarat", isGrouded);
        

        if(isGrouded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        bool isMove = CheckMove(move);

        animator.SetBool("lari" , isMove);

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrouded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            animator.SetBool("lompat", true);
        }else if(isGrouded){
            animator.SetBool("lompat", false);

        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    bool CheckMove (Vector3 move){
        if(move.x != 0 || move.z != 0){
            return true;
        }
        return false;
    }
}
