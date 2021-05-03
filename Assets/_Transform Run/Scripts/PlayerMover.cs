using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float moveSpeed = 10f;
    private void Update()
    {
        MoveForward(); 
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
    }
}
