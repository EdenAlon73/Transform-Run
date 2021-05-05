using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastSword : MonoBehaviour
{
    public bool defeated = false;

    private void OnTriggerEnter(Collider other)
    {
        defeated = true;
    }
}
