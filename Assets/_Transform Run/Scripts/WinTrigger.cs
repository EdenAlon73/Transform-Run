using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    [SerializeField] private PlayerMover playerMover;
    [SerializeField] private FormChanger formChanger;
    private void OnTriggerEnter(Collider other)
    {
        playerMover.Win();
        formChanger.Win();
    }
}
