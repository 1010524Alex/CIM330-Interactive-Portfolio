using UnityEngine;

public class TextScroller : MonoBehaviour, IInteractable
{
    public GameObject pageOne;
    public GameObject pageTwo;

    [SerializeField]
    string objectInteractMessage;
    public string interactMessage => objectInteractMessage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pageOne.SetActive(true);
        pageTwo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        TurnPageForward();
    }

    void TurnPageForward()
    {
        pageOne.SetActive(false);
        pageTwo.SetActive(true);
    }
}
