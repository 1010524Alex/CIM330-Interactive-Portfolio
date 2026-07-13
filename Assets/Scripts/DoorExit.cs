using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DoorExit : MonoBehaviour
{
    public GameObject DoorExitPrefab;
    public bool isWithinDoor;
    public TextMeshProUGUI doorText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isWithinDoor = false;
        doorText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        exitGame();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isWithinDoor = true;
            doorText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isWithinDoor = false;
            doorText.enabled = false;
        }
    }

    void exitGame()
    {
        if (isWithinDoor == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(2);
        }
    }


}
