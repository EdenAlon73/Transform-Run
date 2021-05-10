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
    [SerializeField] private GameObject blinkPanel;
    [SerializeField] private BiomTypeChecker biom;
    private void Start()
    {
        formChanger = GetComponent<FormChanger>();
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveForward();
        BlinkPanelControl();
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
        StopMoving();
    }

    public void StopMoving()
    {
            moveSpeed = 0;
            horseMoveSpeed = 0;
    }

    private void BlinkPanelControl()
    {
        if(biom != null)
        {
            if (biom.wrongForm)
            {
                blinkPanel.SetActive(true);
            }
            else
            {
                blinkPanel.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        biom = other.GetComponent<BiomTypeChecker>();
    }

}
