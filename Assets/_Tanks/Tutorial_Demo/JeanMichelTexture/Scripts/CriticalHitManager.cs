using System;
using System.Collections;
using System.Collections.Generic;
using Tanks.Complete;
using UnityEngine;

public class CriticalHitManager : MonoBehaviour
{
    public Material m_CritcalMaterial;
    public float m_CriticalEffectDuration = 0.5f;
    public AudioSource m_ShootingAudio;         // Reference to the audio source used to play the shooting audio. NB: different to the movement audio source.
    public AudioClip m_CriticalClip;            // Audio that plays when a critical hit is applied.

    private float m_CriticalEffectStartTime = 0.12f; // Time when the critical effect started.

    public void DisplayCritical()
    {
        // Start the critical effect coroutine
        StartCoroutine(CriticalEffectCoroutine());
    }

    private IEnumerator CriticalEffectCoroutine()
    {
        // Play the critical hit sound
        m_ShootingAudio.clip = m_CriticalClip;
        m_ShootingAudio.volume = 1.0f;
        m_ShootingAudio.time = m_CriticalEffectStartTime; // Start the audio from the critical hit point
        m_ShootingAudio.Play();

        // Wait a bit for sync with the sound
        //yield return new WaitForSeconds(0.4f);

        // Display Critical Hit effect
        m_CritcalMaterial.SetFloat("_CriticalTrigger", 1f);

        CriticalTextManager textManager = GameObject.Find("Menus").GetComponentInChildren<CriticalTextManager>();
        if (textManager)
        {
            textManager.DisplayCritical();            
        }

        CameraControl cameraShake = GameObject.Find("CameraRig").GetComponent<CameraControl>();
        cameraShake.StartShake();

        // Wait for the duration of the effect
        yield return new WaitForSeconds(m_CriticalEffectDuration);

        // Reset Critical Hit effect
        m_CritcalMaterial.SetFloat("_CriticalTrigger", 0f);

        if (textManager)
        {
            textManager.HideCritical();
        }

        cameraShake.StopShake();

        // Reset the audio
        m_ShootingAudio.volume = 0.2f;
        m_ShootingAudio.time = 0f;
    }
}
