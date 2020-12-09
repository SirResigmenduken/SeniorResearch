using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    void Start()
    {

    }

    void Update()
    {
        if(isInRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
               interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<CharacterController2D>() != null)
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.GetComponent<CharacterController2D>() != null)
        {
            isInRange = false;
        }
    }
}
