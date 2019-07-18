using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_Movement : MonoBehaviour
{
    [SerializeField]
    private float verticalMovementSpeed;

    [SerializeField]
    private float horizontalMovementSpeed;

    private Rigidbody2D thisBody;

    [SerializeField]
    private string horizontalAxis;

    [SerializeField]
    private string verticalAxis;

    private void Start()
    {
        thisBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //I want the avatar to move only when the correct key is pressed. So I set the velocity equal to zero if no keys are
        //currently being pressed.
        //best thing to use in Input.GetAxis because it makes for smoother movement.
        float vert = Input.GetAxis(verticalAxis) * verticalMovementSpeed;
        float horiz = Input.GetAxis(horizontalAxis) * horizontalMovementSpeed;

        thisBody.velocity = new Vector2(horiz, vert) * Time.fixedDeltaTime;
    }
}
