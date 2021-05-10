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
    [SerializeField] private GameObject z;
    [SerializeField] private GameObject zUpper;
    [SerializeField] private GameObject zLower;
    [SerializeField] private TrailRenderer trail;
    [SerializeField] private SphereCollider playerColl;
    private void Awake()
    {
        playerMover = FindObjectOfType<PlayerMover>();
        player2Mover = FindObjectOfType<Player2Mover>();
    }
    public void StartGame()
    {
        playerMover.horseMoveSpeed = playerMover.ogHorseMoveSpeed;
        player2Mover.horseMoveSpeed = 15f;
        zCutOut.enabled = true;
        zCutOutTop.enabled = true;
        zCutOutBot.enabled = true;
        Invoke("CanvsFadeInAnim", 1f);
        Invoke("TrailFade", 0.5f);
        Invoke("CameraSwitch" , 0.3f);
    }
    
    private void CanvsFadeInAnim()
    {
        canvasAnim.SetBool("FadeIn", true);
        z.SetActive(false);
        zUpper.SetActive(false);
        zLower.SetActive(false);
        playerColl.enabled = false;
    }
    private void TrailFade()
    {
       
        trail.enabled = false;
    }
    private void CameraSwitch()
    {
        camera2.SetActive(false);
        camera1.SetActive(true);
    }
}
