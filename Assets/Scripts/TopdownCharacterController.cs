using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class TopdownCharacterController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public Camera mainCamera;
    public Vector3 offset;
    public bool isMoving;
    public Animator Animator_m;
    bool inputProcces_b = false;
    private void Start()
    {
        Animator_m.gameObject.GetComponent<Animator>();



    }
    // Update is called once per frame
    void Update()
    {
        inputProccess();
        // camera follow
        if (mainCamera)
        {
            mainCamera.transform.position = new Vector3(transform.position.x + offset.x, transform.position.y + offset.y, offset.z);
        }

        Debug.Log(inputProcces_b);

        if (inputProcces_b == false)
        {
            Animator_m.SetBool("IsMoving", false);
        }
        if (inputProcces_b == true)
        {
            Animator_m.SetBool("IsMoving", true);
        }
    }
    // updates only when needed
    private void FixedUpdate()
    {
        move();

        inputProcces_b = false;

    }
    // proccessing inputs works with wads and directional keys
    void inputProccess()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        if (moveX != 0 || moveY != 0)
        {
            inputProcces_b = true;
        }        
    }
    // moves sprite according to inputs
    void move()
    {

        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);



    }


}