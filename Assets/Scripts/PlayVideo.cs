using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public GameObject videoScreen;
    public bool isWithinButtonRadius;
    public VideoPlayer video;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isWithinButtonRadius = false;
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
        }
        else
        {
            isWithinButtonRadius = false;
        }
    }

    void buttonPress()
    {
        if (isWithinButtonRadius == true && Input.GetKeyDown(KeyCode.E))
        {
            video.Play();
            Debug.Log("Button is pressed");
        }
    }
}
