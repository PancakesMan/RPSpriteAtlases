using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    Animator animator;
    Button button;

    // Start is called before the first frame update
    void Start()
    {
        // Gets a reference to the Animator components and stores it in the animator variable
        animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // If animator is not null
        if (animator)
        {
            // Set a bool on the animator to start playing an animation
            animator.SetBool("Mouse Over", true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // If animator is not null
        if (animator)
        {
            // Set a bool on the animator to stop playing an animation
            animator.SetBool("Mouse Over", false);
        }
    }
}
