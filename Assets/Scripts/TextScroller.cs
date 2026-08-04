using UnityEngine;

public class TextScroller : MonoBehaviour, IInteractable
{
    public GameObject pageOne;
    public GameObject pageTwo;
    public AudioSource buttonAudio;
    public Animator scrollButtonAnim;

    [SerializeField]
    string objectInteractMessage;
    public string interactMessage => objectInteractMessage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pageOne.SetActive(true);
        pageTwo.SetActive(false);
        scrollButtonAnim = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        TurnPage();
    }

    void TurnPage()
    {
        pageOne.SetActive(false);
        pageTwo.SetActive(true);
        buttonAudio.Play();
        scrollButtonAnim.SetTrigger("Press Button");
    }
}
