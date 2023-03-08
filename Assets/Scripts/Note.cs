using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.VFX;


public class Note : MonoBehaviour
{
    public string displayName;
    public string noteName;
    public GameObject visualEffectContainer;
    public int effectDuration = 4;
    public AudioSource audioSource;

    private LevelManager levelManager;

    private void Start()
    {
        audioSource = gameObject.GetComponentInChildren<AudioSource>();
        levelManager = FindObjectOfType<LevelManager>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("OctaviCopter"))
        {
            NoteHitActivities();
        }

    }

    private void NoteHitActivities()
    {
        audioSource.PlayOneShot(audioSource.clip);
        // maybe haptic feedback here?

        levelManager.OnNoteCollected(noteName);

    }

    public void TurnOnHintEffect()
    {
        visualEffectContainer.SetActive(true);

    }

    public void TurnOffHintEffect()
    {
        visualEffectContainer.SetActive(false);

    }


}