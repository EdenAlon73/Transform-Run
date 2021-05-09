using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2WinTrigger : MonoBehaviour
{
    [SerializeField] private Player2Mover playerMover;
    [SerializeField] private Player2FormChanger formChanger;
    private void OnTriggerEnter(Collider other)
    {
        playerMover.Win();
        formChanger.Win();
    }
}
