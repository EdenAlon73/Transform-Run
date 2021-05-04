using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControll : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Animator animator;
    private FormChanger formChanger;
    [SerializeField] private bool isSwordEnemy = false;
    [SerializeField] private bool isGunEnemy = false;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent <Animator>();
        formChanger = FindObjectOfType<FormChanger>();
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FormChanger>())
        {
            if (formChanger.isSword)
            {
                animator.speed = 5;
                animator.SetBool("Fall", true);
            }
        }
        
    }


}
