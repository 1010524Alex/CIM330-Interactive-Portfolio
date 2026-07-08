using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class RemoveLightText : MonoBehaviour
{
    public GameObject lightText;
    public AudioSource lightSwitchAudio;
    public bool isLightOn =false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            lightText.SetActive(false);
            Cursor.lockState = CursorLockMode.None;

            if (!isLightOn)
            {
                isLightOn = true;
                playLightSwitchAudio();
            }
        }
    }

    void playLightSwitchAudio()
    {
        lightSwitchAudio.Play();
    }



}
