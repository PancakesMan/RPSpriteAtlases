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
        animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (animator)
        {
            animator.SetBool("Mouse Over", true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (animator)
        {
            animator.SetBool("Mouse Over", false);
        }
    }
}
