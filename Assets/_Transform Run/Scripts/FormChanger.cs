using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormChanger : MonoBehaviour
{
    [SerializeField] private GameObject boxForm;
    [SerializeField] private GameObject cylinderForm;
    [SerializeField] private GameObject sphereForm;
    [SerializeField] private ParticleSystem smoke;
    public bool isBox;
    public bool isCylinder;
    public bool isSphere;

    public void Start()
    {
        isBox = true;
        isCylinder = false;
        isSphere = false;
    }
    public void ChangeToBox()
    {
        if (!isBox)
        {
            smoke.Play();
        }
        boxForm.SetActive(true);
        cylinderForm.SetActive(false);
        sphereForm.SetActive(false);
        isBox = true;
        isCylinder = false;
        isSphere = false;
    }

    public void ChangeToCylinder()
    {
        if (!isCylinder)
        {
            smoke.Play();
        }
        cylinderForm.SetActive(true);
        boxForm.SetActive(false);
        sphereForm.SetActive(false);
        isCylinder = true;
        isSphere = false;
        isBox = false;
    }

    public void ChangeToSphere()
    {
        if (!isSphere)
        {
            smoke.Play();
        }
        sphereForm.SetActive(true);
        cylinderForm.SetActive(false);
        boxForm.SetActive(false);
        isSphere = true;
        isBox = false;
        isCylinder = false;
    }
}
