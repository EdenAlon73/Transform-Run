using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormChanger : MonoBehaviour
{
    [SerializeField] private GameObject horseForm;
    [SerializeField] private GameObject sneakingForm;
    [SerializeField] private GameObject swordForm;
    [SerializeField] private ParticleSystem smoke;
    public bool isHorse;
    public bool isSneaking;
    public bool isSword;

    public void Start()
    {
        isHorse = true;
        isSneaking = false;
        isSword = false;
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
}
