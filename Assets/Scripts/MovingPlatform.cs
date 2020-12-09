 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class MovingPlatform : MonoBehaviour
 {
     private Vector3 startPos;
     public Transform target;
     public float speed;
     private bool moveUp;
     private bool move;
     public float delay;
     public float delayTimer = 3f;

     void Start()
     {
         startPos = transform.position;
         moveUp = true;
         move = false;
     }

     public void Move()
     {
        move = true;
        delay = Time.time + delayTimer;
     }

     void Update()
     {
         if(move)
         {
            float step = speed * Time.deltaTime;
            if(transform.position == target.position && delay < Time.time)
            {       
                moveUp = false;
                delay = Time.time + delayTimer;
            }
            else if(transform.position == startPos && delay < Time.time)
            {
                 moveUp = true;
                delay = Time.time + delayTimer;
            }
        
            if(moveUp == false)
            {  
                transform.position = Vector3.MoveTowards(transform.position, startPos, step);

            }

            else if(moveUp)
            {
                        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }

        }
     }
 }
