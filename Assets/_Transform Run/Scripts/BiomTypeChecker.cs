﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiomTypeChecker : MonoBehaviour
{
    [SerializeField] private FormChanger formChanger;
    [SerializeField] private PlayerMover playerMover;

    [SerializeField] private bool boxBiom = true;
    [SerializeField] private bool cylinderBiom = false;
    [SerializeField] private bool sphereBiom= false;

    private void SpeedControll()
    {
        
        if (boxBiom)
        {
            if (formChanger.isBox)
            {
                playerMover.moveSpeed = 5f;
            }
            if (!formChanger.isBox)
            {
                playerMover.moveSpeed = 1f;
            }
        }
        if (cylinderBiom)
        {
            print("cylBiom");
            if (formChanger.isCylinder)
            {
                playerMover.moveSpeed = 5f;
                print("isCyl");
            }
            if (!formChanger.isCylinder)
            {
                playerMover.moveSpeed = 1f;
                print("notCyl");
            }
        }

        if (sphereBiom)
        {
            if (formChanger.isSphere)
            {
                playerMover.moveSpeed = 5f;
            }
            if (!formChanger.isSphere)
            {
                playerMover.moveSpeed = 1f;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        SpeedControll();
    }
}