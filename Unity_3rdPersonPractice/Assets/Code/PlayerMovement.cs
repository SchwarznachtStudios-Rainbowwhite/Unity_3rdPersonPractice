using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //PlayerMovement
    [Header("Camera")]
    public CameraDirection _CamDirection;
    [Space]

    [Header("Player")]
    public Rigidbody _PlayerRB;
    [Space]

    [Header("Variables")]
    public float _MoveSpeed = 5f;

    public Animator _Animator;


    // START START START START
    void Start()
    {



    }

    // UPDATE UPDATE UPDATE UPDATE
    void FixedUpdate()
    {
        Vector2 _movementInput;


        //PlayerInput
        _movementInput.x = Input.GetAxisRaw("Horizontal");
        _movementInput.y = Input.GetAxisRaw("Vertical");

        Movement(_movementInput);

    }


    // FUNKTIONEN MOVEMENT


    //Movement of Player
    public void Movement(Vector2 _movementInput)
    {
        //Adding Force to the Player in the 3D Space per rigidbody/Assign rigidbody to movementvectors?
        Vector3 newVelocity = _PlayerRB.velocity;

        newVelocity = CalculateHorizontalMovement(newVelocity, _movementInput);


        _PlayerRB.velocity = newVelocity;


        //Wenn Bewegung, dann transformiere Charakter in die Richtung der Kamera
        if (newVelocity.magnitude > 0)
        {
            transform.forward = _CamDirection.GetCameraForward();
            _Animator.SetBool("isMoving", true);
            
        }
        else _Animator.SetBool("isMoving", false);

    }

    //Calculate the horizontal movement of the player with speed and direction
    private Vector3 CalculateHorizontalMovement(Vector3 newVelocity, Vector2 _movementInput)
    {
        Vector3 forwardDirection = _movementInput.y * _CamDirection.GetCameraForward();
        Vector3 sidewardDirection = _movementInput.x * _CamDirection.GetCameraSideward();

        Vector3 generalDirection = forwardDirection + sidewardDirection;
        generalDirection = generalDirection.normalized;

        newVelocity = generalDirection * _MoveSpeed;

        return newVelocity;


    }

}
