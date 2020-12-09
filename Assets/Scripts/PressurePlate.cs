using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public Animator animator;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<CharacterController2D>() != null)
        {
            animator.SetFloat("On", 1);
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.GetComponent<CharacterController2D>() != null)
        {
            animator.SetFloat("On", 0);
        }
    }
}
