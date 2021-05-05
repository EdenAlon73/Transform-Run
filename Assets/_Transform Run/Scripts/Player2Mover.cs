using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Mover : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float horseMoveSpeed = 10f;
    private FormChanger formChanger;
    private bool canMove = true;
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
        horseMoveSpeed = 15f;
    }
    public void Win()
    {
        canMove = false;
    }
}
