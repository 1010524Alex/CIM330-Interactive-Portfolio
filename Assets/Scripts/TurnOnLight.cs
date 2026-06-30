using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;
using TMPro;

public class TurnOnLight : MonoBehaviour
{
    public Bloom bloomSetting;
    public GameObject light_1;
    public GameObject darknessBox;
    public TextMeshProUGUI lightText;
    public bool isLightOn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isLightOn = false;
        lightText.enabled = true;
        light_1.SetActive(false);
        bloomSetting = GetComponent<Bloom>();
        bloomSetting.intensity.value = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            switchLightOn();
        }

        if (isLightOn == true)
        {
            lightText.enabled = false;
        }
    }

    void switchLightOn()
    {
        light_1.SetActive(true);
        darknessBox.SetActive(false);
        bloomSetting.intensity.value = 100;
        isLightOn = true;
    }
}
