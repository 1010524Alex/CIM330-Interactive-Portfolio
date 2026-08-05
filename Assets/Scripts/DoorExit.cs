using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DoorExit : MonoBehaviour, IInteractable
{
    
    [SerializeField]
    string objectInteractMessage;

    public string interactMessage => objectInteractMessage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void exitGame()
    {
        {
            SceneManager.LoadScene(2);
        }
    }

    public void Interact()
    {
        exitGame();
    }
}
