using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryCharge : MonoBehaviour
{
[SerializeField] float angleAmount = 70f;
[SerializeField] float intensityAmount = 10f;
   private void OnTriggerEnter(Collider other) 
   {
    if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightAngle(angleAmount);
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightIntensity(intensityAmount);
            Destroy(gameObject);
        }
   }
}
