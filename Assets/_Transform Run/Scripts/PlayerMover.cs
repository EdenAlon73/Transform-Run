using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float horseMoveSpeed = 10f;
    private FormChanger formChanger;

    private void Start()
    {
        formChanger = GetComponent<FormChanger>();
    }

    private void Update()
    {
        MoveForward(); 
    }

    private void MoveForward()
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
