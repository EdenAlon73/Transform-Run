using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiomTypeChecker : MonoBehaviour
{
    [SerializeField] private FormChanger formChanger;
    [SerializeField] private PlayerMover playerMover;
    
    [SerializeField] private bool sneakingBiome = false;
    [SerializeField] private bool swordBiome= false;

    private void SpeedControll()
    {
        
       
        if (sneakingBiome)
        {
            if (formChanger.isSneaking)
            {
                playerMover.moveSpeed = 5f;
            }
            if (!formChanger.isSneaking)
            {
                playerMover.moveSpeed = 1f;
            }
        }

        if (swordBiome)
        {
            if (formChanger.isSword)
            {
                playerMover.moveSpeed = 5f;
            }
            if (!formChanger.isSword)
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
