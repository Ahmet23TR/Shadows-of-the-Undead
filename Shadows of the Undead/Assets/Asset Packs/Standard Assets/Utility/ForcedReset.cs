using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // UI.Image için bu satırı ekledik
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Image))] // GUITexture yerine UI.Image kullanıyoruz
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // Eğer bir sıfırlama işlemi yapmamız gerekiyorsa...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            // ... sahneyi yeniden yükle
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
