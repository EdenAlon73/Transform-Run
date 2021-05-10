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
    public bool wrongForm = false;
    
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
                playerMover.horseMoveSpeed = playerMover.slowMoveSpeed;
                if (formChanger.isSneaking)
                {
                    playerMover.moveSpeed = playerMover.ogMoveSpeed;
                    wrongForm = false;
                }
                if (!formChanger.isSneaking)
                {
                    playerMover.moveSpeed = playerMover.slowMoveSpeed;
                    wrongForm = true;
                }
            }

            if (swordBiome)
            {
                if (!lastSword.defeated)
                {
                   //playerMover.horseMoveSpeed = playerMover.slowMoveSpeed;
                    if (formChanger.isSword)
                    {
                        playerMover.moveSpeed = playerMover.ogMoveSpeed;
                        wrongForm = false;
                        playerMover.FreeConstraints();
                        print("is sword Right");
                    }
                    if (!formChanger.isSword)
                    {
                        print("is sword wrong");
                        playerMover.StopMoving();
                        wrongForm = true;
                    }
                }
                else
                {
                    playerMover.horseMoveSpeed = playerMover.ogHorseMoveSpeed;
                    playerMover.moveSpeed = playerMover.ogMoveSpeed;
                    playerMover.FreeConstraints();
                    wrongForm = false;
                }

            }
        }
        
    }
    private void Player2SpeedControl()
    {
        if((isPlayer2Lane))
        {
            if (sneakingBiome)
            {
                player2Mover.horseMoveSpeed = player2Mover.slowMoveSpeed;
                Invoke("ChageFormPlayer2", Random.Range(0.5f, 1.5f));
                if (player2FormChanger.isSneaking)
                {
                    player2Mover.moveSpeed = player2Mover.ogMoveSpeed;
                }
                if (!player2FormChanger.isSneaking)
                {
                    player2Mover.moveSpeed = player2Mover.slowMoveSpeed;
                }
            }


            if (swordBiome)
            {
                if (!lastSword.defeated)
                {
                    player2Mover.horseMoveSpeed = player2Mover.slowMoveSpeed;
                    Invoke("ChageFormPlayer2", Random.Range(0.5f, 1.5f));
                    if (player2FormChanger.isSword)
                    {
                        player2Mover.moveSpeed = player2Mover.ogMoveSpeed;
                    }
                    if (!player2FormChanger.isSword)
                    {
                        player2Mover.moveSpeed = player2Mover.slowMoveSpeed;
                    }
                }
                else
                {
                    player2Mover.horseMoveSpeed = player2Mover.ogHorseMoveSpeed;
                    player2Mover.moveSpeed = player2Mover.ogMoveSpeed;
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
            Player2SpeedControl();
        }
      
    }

    private void OnTriggerExit(Collider other)
    {
        if (!isPlayer2Lane)
        {
            playerMover.ChangeHorseSpeed();
            playerMover.moveSpeed = playerMover.ogMoveSpeed;
            playerMover.FreeConstraints();
        }
        else
        {
            player2Mover.ChangeHorseSpeed();
            player2Mover.moveSpeed = player2Mover.ogMoveSpeed;
            player2FormChanger.HorseChanger();
        }
       
    }
}
