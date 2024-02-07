using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class ControllerData : MonoBehaviour
{
    [SerializeField] InputActionReference toggleright;
    [SerializeField] InputActionReference toggleleft;
    [SerializeField] InputActionReference jumpright;
    [SerializeField] InputActionReference jumpleft;
    [SerializeField] InputActionReference jumpkey;
    [SerializeField] float jumpForce = 50f;
    private Rigidbody rb;


    private void Start()
    {
        jumpleft.action.performed += OnJump;
        jumpright.action.performed += OnJump;
        jumpkey.action.performed += OnJump;
    }

    void OnJump(InputAction.CallbackContext context)
    {
        rb.AddForce(Vector3.up*jumpForce);
    }





    private void Awake()
    {
        toggleright.action.started += ToggleObject;
        toggleleft.action.started += ToggleObject;
        rb = GetComponent<Rigidbody>();
    }



    private void ToggleObject(InputAction.CallbackContext context)
    {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }
}
