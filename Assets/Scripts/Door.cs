 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;

 public class Door : MonoBehaviour
 {
     private Vector3 startPos;
     public Transform target;
     public float speed;
     private bool move;

     void Start()
     {
         startPos = transform.position;
         move = false;
     }

     public void Move()
     {
        move = true;
     }

     void Update()
     {
        if(move)
        {   
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
     }
 }