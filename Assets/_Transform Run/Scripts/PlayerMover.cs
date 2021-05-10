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
    public GameObject blinkPanel;
    [SerializeField] private BiomTypeChecker biom;
    private RigidbodyConstraints ogConstarints;
    private void Start()
    {
        formChanger = GetComponent<FormChanger>();
        myRigidbody = GetComponent<Rigidbody>();
        ogConstarints = myRigidbody.constraints;
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
               // transform.Translate(Vector3.forward * (horseMoveSpeed * Time.deltaTime));
                myRigidbody.velocity = Vector3.forward * (horseMoveSpeed * Time.deltaTime);
            }
            else
            {
                //transform.Translate(Vector3.forward * (moveSpeed * Time.deltaTime));
                myRigidbody.velocity = Vector3.forward * (moveSpeed * Time.deltaTime);
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
        myRigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }

    public void FreeConstraints()
    {
       myRigidbody.constraints = ogConstarints;
    }
    private void BlinkPanelControl()
    {
        if(biom != null)
        {
            if (biom.wrongForm)
            {
                blinkPanel.SetActive(true);
                print("Blink control true");
            }
            else
            {
                blinkPanel.SetActive(false);
                print("Blink control false");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        biom = other.GetComponent<BiomTypeChecker>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(biom == null)
        {
            biom = other.GetComponent<BiomTypeChecker>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        blinkPanel.SetActive(false);
        print("exit");
    }

}
