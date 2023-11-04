using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
   [SerializeField] float lightDecay = 0.1f;
   [SerializeField] float angleDecay = 1f;
   [SerializeField] float minimumAngle = 40f;

   Light myLight;

   private void Start() 
   {
        myLight = GetComponent<Light>();
   }

    private void Update() {
        DecraseLightAngle();
        DecraseLightIntensity();
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        myLight.spotAngle = restoreAngle;
    }
    public void RestoreLightIntensity(float intensityAmount)
    {
        myLight.intensity += intensityAmount;
    }

    private void DecraseLightIntensity()
    {
        if (myLight != null)
        {
            if (myLight.intensity > 0)
            {
                myLight.intensity -= lightDecay * Time.deltaTime; 
            }
            else
            {
                myLight.intensity = 0; 
            }
        }    
    }

    private void DecraseLightAngle()
    {
        if (myLight != null)
        {
            if (myLight.spotAngle > minimumAngle)
            {
                myLight.spotAngle -= angleDecay * Time.deltaTime; 
            }
            else
            {
                return;
            }
        }    
    }
}
