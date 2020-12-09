using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator animator;
    private float timer;
    
    public void ButtonOn()
    {
        timer = 1f;
        animator.SetBool("IsOn", true);
    }

    public void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                animator.SetBool("IsOn", false);
            }
        }
    }
    


}

