using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZWallLogic : MonoBehaviour
{
    [SerializeField]private GameObject normalWall;
    [SerializeField]private GameObject crackedWall;
    private void OnTriggerEnter(Collider other)
    {
        normalWall.SetActive(false);
        crackedWall.SetActive(true);
    }
}
