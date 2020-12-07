using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public  float playerSpeed;
    private Rigidbody2D rb2d;
    // Update is called once per frame
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Vector3 movement = new Vector3(Input.GetAxis("MoveHorizontal"), Input.GetAxis("MoveVertical"), 0.0f); // This is used for Xbox controlls. Right Now you can only really see the walk animation if you use xbox controls.
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")); //This is used for PC controlls. Right Now you can only really see the walk animation if you use xbox controls.
        movement = movement.normalized;
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        rb2d.velocity = (movement *  playerSpeed);
    }
}
