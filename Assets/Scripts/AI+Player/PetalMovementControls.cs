using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetalMovementControls : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 touchPosition;
    Vector3 direction;
    public float moveSpeedMouse = 0.035f;
    public float moveSpeedFinger = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //movement
    private void Update()
    {
        MouseMovement();
        //FingerControl();
    }

    private void MouseMovement()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeedMouse);
    }

    private void FingerControl()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * moveSpeedFinger;

            if(touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }

    // for mouse movement
    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }


}
