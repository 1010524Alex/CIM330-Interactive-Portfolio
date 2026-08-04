using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using TMPro;

public class PlayVideo : MonoBehaviour, IInteractable
{
    public GameObject videoScreen;
    public bool isWithinButtonRadius;
    public VideoPlayer video;
    public TextMeshProUGUI buttonText;
    public AudioSource buttonAudio;
    public Animator buttonPressAnimation;

    [SerializeField]
    string objectInteractMessage;

    public string interactMessage => objectInteractMessage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buttonPressAnimation = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void buttonPress()
    {       
        {
            video.Play();
            Debug.Log("Button is pressed");
            buttonAudio.Play();
            buttonPressAnimation.SetTrigger("Button One");
        }
    }

    public void Interact()
    {
        buttonPress();
    }
}
