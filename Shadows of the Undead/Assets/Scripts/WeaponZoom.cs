using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] public Camera fpsCamera;
    [SerializeField] public FirstPersonController fpsController;
    [SerializeField] public float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] public float zoomedOutSens = 2f;
    [SerializeField] float zoomedInSens = 0.5f;
    bool zoomedInToggle = false;

    private void OnDisable() 
    {
        ZoomOut();
    }
    

    void Update() 
    {
        if(Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.fieldOfView = zoomedOutFOV;
        fpsController.mouseLook.XSensitivity = zoomedOutSens;
        fpsController.mouseLook.YSensitivity = zoomedOutSens;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.mouseLook.XSensitivity = zoomedInSens;
        fpsController.mouseLook.YSensitivity = zoomedInSens;
    }
}
