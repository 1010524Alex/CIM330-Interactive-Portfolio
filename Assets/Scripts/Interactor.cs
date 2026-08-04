using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField]
    Camera playerCamera;

    [SerializeField]
    TextMeshProUGUI interactionText;

    [SerializeField]
    float InteractionDistance = 5f;

    IInteractable currentTargetInteractable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Update()
    {
        UpdateCurrentInteractable();

        UpdateInteractionText();

        CheckForInteractionInput();
    }

    void UpdateCurrentInteractable()
    {
        var ray = playerCamera.ViewportPointToRay(new Vector2(0.5f, 0.5f));
        Physics.Raycast(ray, out var hit, InteractionDistance);
        currentTargetInteractable = hit.collider?.GetComponent<IInteractable>();
    }

    void UpdateInteractionText()
    {
        if (currentTargetInteractable == null)
        {
            interactionText.text = string.Empty;
            return;
        }

        interactionText.text = currentTargetInteractable.interactMessage;
    }

    void CheckForInteractionInput()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentTargetInteractable != null)
        {
            currentTargetInteractable.Interact();
        }
    }
}
