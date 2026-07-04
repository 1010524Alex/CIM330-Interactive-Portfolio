using UnityEngine;

public class RemoveLightText : MonoBehaviour
{
    public GameObject lightText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            lightText.SetActive(false);
        }
    }
}
