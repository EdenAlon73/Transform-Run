using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2FormChanger : MonoBehaviour
{
    [SerializeField] private GameObject horseForm;
    [SerializeField] private GameObject sneakingForm;
    [SerializeField] private GameObject swordForm;
    [SerializeField] private GameObject zoroWin;
    [SerializeField] private ParticleSystem smoke;
    
    public bool isHorse;
    public bool isSneaking;
    public bool isSword;
    public bool isWin;
    public void Start()
    {
        isHorse = true;
        isSneaking = false;
        isSword = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangeToHorse();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeToSneaking();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            ChangeToSword();
        }
    }
    public void ChangeToHorse()
    {
        if (!isHorse)
        {
            smoke.Play();
        }
        horseForm.SetActive(true);
        sneakingForm.SetActive(false);
        swordForm.SetActive(false);
        isHorse = true;
        isSneaking = false;
        isSword = false;
    }

    public void ChangeToSneaking()
    {
        if (!isSneaking)
        {
            smoke.Play();
        }
        sneakingForm.SetActive(true);
        horseForm.SetActive(false);
        swordForm.SetActive(false);
        isSneaking = true;
        isSword = false;
        isHorse = false;
    }

    public void ChangeToSword()
    {
        if (!isSword)
        {
            smoke.Play();
        }
        swordForm.SetActive(true);
        sneakingForm.SetActive(false);
        horseForm.SetActive(false);
        isSword = true;
        isHorse = false;
        isSneaking = false;
    }

    public void Win()
    {
        smoke.Play();
        zoroWin.SetActive(true);
        swordForm.SetActive(false);
        sneakingForm.SetActive(false);
        horseForm.SetActive(false);
        isWin = true;
        isSword = false;
        isHorse = false;
        isSneaking = false;
    }

    public void HorseChanger()
    {
        Invoke("ChangeToHorse", 0.8f);
    }
}
