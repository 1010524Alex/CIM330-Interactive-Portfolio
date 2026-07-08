using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using TMPro;

public class TurnOnLight : MonoBehaviour
{
    public Bloom bloomSetting;
    public GameObject light_1;
    public GameObject light_2;
    public GameObject darknessBox;
    public TextMeshProUGUI lightText;
    public bool isLightOn;
    public GameObject lightTextObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightTextObject.SetActive(true);
        isLightOn = false;
        lightText.enabled = true;
        light_1.SetActive(false);
        light_2.SetActive(false);
        bloomSetting = GetComponent<Bloom>();
        bloomSetting.intensity.value = 0;
        
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
        }
    }

    void switchLightOn()
    {
        light_1.SetActive(true);
        light_2.SetActive(true);
        darknessBox.SetActive(false);
        bloomSetting.intensity.value = 100;
    }
}
