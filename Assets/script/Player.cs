using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    private float speed;
    public float walkspeed = 4f;
    public float runSpeed = 8f;
    float smoothTurnVelocity;
    public Transform cam;
    public float smoothTime = 0.1f;
    public Animator anim;
    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = SimpleInput.GetAxisRaw("Horizontal");
        float vertical = SimpleInput.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal,0,vertical);

        if (direction.magnitude > 0.1f && Input.GetKey("left shift"))
        {

            anim.SetBool("run", true);


            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurnVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir * runSpeed * Time.deltaTime);

        }
        else if(direction.magnitude > 0.1f && !Input.GetKey("left shift"))
        {

            anim.SetBool("run", false);
            anim.SetBool("walk", true);

            float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurnVelocity, smoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir * walkspeed * Time.deltaTime);
        }

        else
        {
            anim.SetBool("run", false);
            anim.SetBool("walk", false);
        }
    }
}
