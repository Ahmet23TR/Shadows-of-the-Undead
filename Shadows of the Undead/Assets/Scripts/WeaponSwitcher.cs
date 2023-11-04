using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeapon = 0;
    WeaponZoom weaponZoom;
    void Start()
    {
        SetWeaponActive();
    }
    void Update()
    {
        int previousWeapon = currentWeapon;

        ProcessKeyInput();
        ProcessScrollWheel();

        if(previousWeapon != currentWeapon)
        {   
            SetWeaponActive();
        }
    }

    private void ProcessScrollWheel()
    {
        if(Input.GetAxis("Mouse ScrollWheel") < 0 )
        {
            if(currentWeapon >= transform.childCount - 1)
            {
                currentWeapon = 0;
            }
            else 
            {
                currentWeapon++;
            }
        }
        if(Input.GetAxis("Mouse ScrollWheel") > 0 )
        {
            if(currentWeapon <= 0)
            {
                currentWeapon = transform.childCount - 1;
            }
            else 
            {
                currentWeapon--;
            }
        }
    }

    private void ProcessKeyInput()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentWeapon = 3;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentWeapon = 4;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            currentWeapon = 5;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha7))
        {
            currentWeapon = 6;
        }
        
    }

    private void SetWeaponActive()
    {
        int weaponInedex = 0;

        foreach(Transform weapon in transform)
        {
            if(weaponInedex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);
            }
            weaponInedex++;
        }
    }
    
}
