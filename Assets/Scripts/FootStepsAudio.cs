using UnityEngine;

public class FootStepsAudio : MonoBehaviour
{
    public AudioSource footsteps;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.S) || (Input.GetKey(KeyCode.D))))) 
        { 
            footsteps.enabled = true;
        }
        else
        {
            footsteps.enabled = false;
        }
    }
}
