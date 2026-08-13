using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.Timeline;

public class TurnOnLight : MonoBehaviour
{
    private Bloom bloomSetting;
    private DepthOfField depthOfFieldSetting;
    [SerializeField] private Volume postProcessingVolume;
    public GameObject light_1;
    public GameObject light_2;
    public GameObject darknessBox;
    public TextMeshProUGUI lightText;
    public bool isLightOn;
    public GameObject lightTextObject;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightTextObject.SetActive(true);
        isLightOn = false;
        lightText.enabled = true;
        light_1.SetActive(false);
        light_2.SetActive(false);
        postProcessingVolume.profile.TryGet(out bloomSetting);
        postProcessingVolume.profile.TryGet(out depthOfFieldSetting);
        bloomSetting.intensity.value = 100;
        depthOfFieldSetting.focalLength.value = 300;
        bloomSetting.threshold.value = 0.8f;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            switchLightOn();
            isLightOn = true;
        }

        

        if (isLightOn == true)
        {
            lightText.enabled = false;
            lightTextObject.SetActive(false);
            EyesAdjust();
        }
    }

    void switchLightOn()
    {
        light_1.SetActive(true);
        light_2.SetActive(true);
        darknessBox.SetActive(false);
    }

    void EyesAdjust()
    {
        bloomSetting.intensity.value = Mathf.Lerp(bloomSetting.intensity.value, 3.73f, speed * Time.deltaTime);
        bloomSetting.threshold.value = Mathf.Lerp(bloomSetting.threshold.value, 1, speed * Time.deltaTime);
        depthOfFieldSetting.focalLength.value = Mathf.Lerp(depthOfFieldSetting.focalLength.value, 0, speed * Time.deltaTime);
    }
}
