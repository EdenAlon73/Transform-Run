using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrail : MonoBehaviour
{
    [SerializeField] private Player2Mover player2Mover;
    [SerializeField] private PlayerMover playerMover;
    [SerializeField] private Collider zCutOut;
    [SerializeField] private Collider zCutOutTop;
    [SerializeField] private Collider zCutOutBot;
    [SerializeField] private Animator canvasAnim;
    [SerializeField] private GameObject camera1;
    [SerializeField] private GameObject camera2;
    private void Awake()
    {
        playerMover = FindObjectOfType<PlayerMover>();
        player2Mover = FindObjectOfType<Player2Mover>();
    }
    public void StartGame()
    {
        playerMover.horseMoveSpeed = 15f;
        player2Mover.horseMoveSpeed = 15f;
        zCutOut.enabled = true;
        zCutOutTop.enabled = true;
        zCutOutBot.enabled = true;
        Invoke("CanvsFadeInAnim", 1f);
    }
    
    private void CanvsFadeInAnim()
    {
        canvasAnim.SetBool("FadeIn", true);
        camera2.SetActive(false);
        camera1.SetActive(true);
    }
}
