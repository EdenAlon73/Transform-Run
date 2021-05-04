using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonImageChanger : MonoBehaviour
{
    [SerializeField] private Button[] buttons;
    [SerializeField] private Sprite[] imagesOn;
    [SerializeField] private Sprite[] imagesOff;
    private FormChanger formChanger;

    private void Awake()
    {
        buttons = GetComponentsInChildren<Button>();
        formChanger = FindObjectOfType<FormChanger>();
    }

    private void LateUpdate()
    {
        IconOnOff();
    }

    private void IconOnOff()
    {
        //HORSE ICON ----------
        if (formChanger.isHorse)
        {
            buttons[0].image.sprite = imagesOn[0];
        }
        else
        {
            buttons[0].image.sprite = imagesOff[0];
        }
        //SNEAK ICON ----------
        if (formChanger.isSneaking)
        {
            buttons[1].image.sprite = imagesOn[1];
        }
        else
        {
            buttons[1].image.sprite = imagesOff[1];
        }
        //SWORD ICON ----------
        if (formChanger.isSword)
        {
            buttons[2].image.sprite = imagesOn[2];
        }
        else
        {
            buttons[2].image.sprite = imagesOff[2];
        }
    }
}
