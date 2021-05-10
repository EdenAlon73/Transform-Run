using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float horseMoveSpeed = 10f;
    public float ogHorseMoveSpeed = 10f;
    public float ogMoveSpeed = 7f;
    public float slowMoveSpeed = 4f;
    private FormChanger formChanger;
    private Rigidbody myRigidbody;
    [SerializeField] private bool canMove = true;
    private void Start()
    {
        formChanger = GetComponent<FormChanger>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveForward(); 
    }

    private void MoveForward()
    {
        if (canMove)
        {
            if (formChanger.isHorse)
            {
                transform.Translate(Vector3.forward * (horseMoveSpeed * Time.deltaTime));
            }
            else
            {
                transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
            }
        }
    }
    public void ChangeHorseSpeed()
    {
        horseMoveSpeed = ogHorseMoveSpeed;
    }
    public void Win()
    {
        canMove = false;
        if (!canMove)
        {
            myRigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
