using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiomTypeChecker : MonoBehaviour
{
    [SerializeField] private FormChanger formChanger;
    [SerializeField] private PlayerMover playerMover;
    
    [SerializeField] private bool sneakingBiome = false;
    [SerializeField] private bool swordBiome= false;
    [SerializeField] private LastSword lastSword;
    private void Start()
    {
        if (swordBiome)
        {
            lastSword = GetComponentInChildren<LastSword>();
        }
    }
    private void SpeedControll()
    {
        
       
        if (sneakingBiome)
        {
            playerMover.horseMoveSpeed = 1f;
            if (formChanger.isSneaking)
            {
                playerMover.moveSpeed = 10f;
            }
            if (!formChanger.isSneaking)
            {
                playerMover.moveSpeed = 1f;
            }
        }

     
        if (swordBiome)
        {
            if (!lastSword.defeated)
            {
                playerMover.horseMoveSpeed = 1f;
                if (formChanger.isSword)
                {
                    playerMover.moveSpeed = 10f;
                }
                if (!formChanger.isSword)
                {
                    playerMover.moveSpeed = 1f;
                }
            }
            else
            {
                playerMover.horseMoveSpeed = 15;
                playerMover.moveSpeed = 10;
            }
           
        }
    }
    private void OnTriggerStay(Collider other)
    {
        SpeedControll();
    }

    private void OnTriggerExit(Collider other)
    {
        playerMover.ChangeHorseSpeed();
        playerMover.moveSpeed = 10f;
    }
}
