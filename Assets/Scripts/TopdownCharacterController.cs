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
    public Transform player;


    // Update is called once per frame
    void Update()
    {
        inputProccess();
       // camera follow
        if (mainCamera)
        {
            transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
        }

    }
    // updates only when needed
    private void FixedUpdate()
    {
        move();
    }
    // proccessing inputs works with wads and directional keys
    void inputProccess()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        
        moveDirection = new Vector2(moveX, moveY).normalized;
        
    }
    // moves sprite according to inputs
    void move()
    {
      
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    
       
    }


}
