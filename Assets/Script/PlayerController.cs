using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private CharacterController _characterController;

    public float Speed = 5.0f;

    public float RotationSpeed = 240.0f;

    private float Gravity = 20.0f;

    private Vector3 _moveDir = Vector3.zero;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (v < 0)
            v = 0;

        transform.Rotate(0, h * RotationSpeed * Time.deltaTime, 0);

        if (_characterController.isGrounded)
        {
            bool move = (v > 0) || (h != 0);

            //_moveDir


        }
    }
}
