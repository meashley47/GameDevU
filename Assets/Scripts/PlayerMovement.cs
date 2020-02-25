using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        ProcessKeyPress();
    }

    void ProcessKeyPress()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * Vector2.right * movementSpeed * Time.deltaTime);
        transform.Translate(Input.GetAxisRaw("Vertical") * Vector2.up * movementSpeed * Time.deltaTime);
    }
}
