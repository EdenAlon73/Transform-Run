using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiomTypeChecker : MonoBehaviour
{
    [SerializeField] private FormChanger formChanger;
    [SerializeField] private Player2FormChanger player2FormChanger;
    [SerializeField] private PlayerMover playerMover;
    [SerializeField] private LastSword lastSword;
    [SerializeField] private Player2Mover player2Mover;
    [SerializeField] private bool sneakingBiome = false;
    [SerializeField] private bool swordBiome= false;
    [SerializeField] private bool isPlayer2Lane = false;
    
    private void Start()
    {
        if (swordBiome)
        {
            lastSword = GetComponentInChildren<LastSword>();
        }
    }
    private void SpeedControll()
    {
        if (!isPlayer2Lane)
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
        else
        {
            if (sneakingBiome)
            {
                player2Mover.horseMoveSpeed = 1f;
                Invoke("ChageFormPlayer2", Random.Range(0.5f,1.5f) );
                if (player2FormChanger.isSneaking)
                {
                    player2Mover.moveSpeed = 10f;
                }
                if (!player2FormChanger.isSneaking)
                {
                    player2Mover.moveSpeed = 1f;
                }
            }


            if (swordBiome)
            {
                if (!lastSword.defeated)
                {
                    player2Mover.horseMoveSpeed = 1f;
                    Invoke("ChageFormPlayer2", Random.Range(0.5f, 1.5f));
                    if (player2FormChanger.isSword)
                    {
                        player2Mover.moveSpeed = 10f;
                    }
                    if (!player2FormChanger.isSword)
                    {
                        player2Mover.moveSpeed = 1f;
                    }
                }
                else
                {
                    player2Mover.horseMoveSpeed = 15;
                    player2Mover.moveSpeed = 10;
                }

            }
        }
        
    }
    private void ChageFormPlayer2()
    {
        if (sneakingBiome)
        {
            player2FormChanger.ChangeToSneaking();
        }

        if (swordBiome)
        {
            player2FormChanger.ChangeToSword();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SpeedControll();
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (!isPlayer2Lane)
        {
            playerMover.ChangeHorseSpeed();
            playerMover.moveSpeed = 10f;
        }
        else
        {
            player2Mover.ChangeHorseSpeed();
            player2Mover.moveSpeed = 10f;
            player2FormChanger.HorseChanger();
        }
       
    }
}
