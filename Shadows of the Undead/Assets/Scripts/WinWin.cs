using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinWin : MonoBehaviour
{
    [SerializeField] Canvas winCanvas;

    void Start() 
    {
        winCanvas.enabled = false;    
    }

   void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "win")
        {
        startSuccesSequence ();       
        }  
        else return;
    }

    void startSuccesSequence ()
    {
        winCanvas.enabled = true;
        var firstPersonControllerCamera = GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
        firstPersonControllerCamera.enabled=false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0;
        FindObjectOfType<WeaponSwitcher>().enabled = false;
    }

}
