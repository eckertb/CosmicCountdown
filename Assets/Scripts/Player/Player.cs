using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    IInputMovementHandler inputMovementHandler;

    // Start is called before the first frame update
    void Start()
    {
        inputMovementHandler = new InputMovementHandler(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        inputMovementHandler.ProcessMovement();
    }
}
