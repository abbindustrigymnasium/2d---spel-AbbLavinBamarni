using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour

{
 [SerializeField] private Vector3 pointA = new Vector3(-2, 0, 0); // where the gameObject starts
 [SerializeField] private Vector3 pointB = new Vector3(2, 0, 0); //where the gameObject finishes
 [SerializeField] private float speed = 1; //with what speed

//returns from pointB to pointA
 private float t;
 private void Update()
        {
        t += Time.deltaTime * speed;
        // Moves the object to target position
        transform.position = Vector3.Lerp(pointA, pointB, t);
                // Flip the points once it has reached the target
                if (t >= 1)
                {
                    var b = pointB;
                    var a = pointA;
                    pointA = b;
                    pointB = a;
                    t = 0;
                }
        }
        
 
}