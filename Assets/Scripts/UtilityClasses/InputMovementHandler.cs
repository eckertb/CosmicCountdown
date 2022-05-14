using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovementHandler : IInputMovementHandler
{
    GameObject g;
    float movementSpeed;
    Vector2 position;
    Quaternion rotation;

    public InputMovementHandler(GameObject g, float movementSpeed = 5f)
    {
        this.g = g;
        this.movementSpeed = movementSpeed;
        this.position = new Vector2();
        this.rotation = new Quaternion();
    }

    public void ProcessMovement()
    {
        this.position.x = Input.GetAxis("Horizontal");
        this.position.y = Input.GetAxis("Vertical");

        g.transform.Translate(position * Time.deltaTime * this.movementSpeed);
    }

    public void ProcessRotation()
    {
        throw new System.NotImplementedException();
    }
}
