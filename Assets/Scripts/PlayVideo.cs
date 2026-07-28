using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class PlayVideo : MonoBehaviour
{
    public GameObject videoScreen;
    public bool isWithinButtonRadius;
    public VideoPlayer video;
    public TextMeshProUGUI buttonText;
    public AudioSource buttonAudio;
    public Animator buttonPressAnimation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isWithinButtonRadius = false;
        buttonText.enabled = false;
        buttonPressAnimation = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonPress();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Is In Space?");
        if (other.gameObject.tag == "Player")
        {
            isWithinButtonRadius = true;
            buttonText.enabled = true;
        }       
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Has Left Space");
        if (other.gameObject.tag == "Player")
        {
            isWithinButtonRadius = false;
            buttonText.enabled = false;
        }
    }

    void buttonPress()
    {
        if (isWithinButtonRadius == true && Input.GetKeyDown(KeyCode.E))
        {
            video.Play();
            Debug.Log("Button is pressed");
            buttonAudio.Play();
            buttonPressAnimation.SetTrigger("Button One");
        }
    }
}
