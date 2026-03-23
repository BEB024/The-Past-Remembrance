using UnityEngine;


public class FixGrabInit : MonoBehaviour
{
    UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grab;

    void Awake()
    {
        grab = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();
    }

    void Update()
    {
        if (grab != null && grab.isSelected)
            return; // 🚨 STOP overriding while grabbed

        // your movement logic here
    }
}