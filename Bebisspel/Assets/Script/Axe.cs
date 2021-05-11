using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour

{
 [SerializeField] private Vector3 pointA = new Vector3(-2, 0, 0);
 [SerializeField] private Vector3 pointB = new Vector3(2, 0, 0);
 [SerializeField] private float speed = 1;

 private float t;
 private void Update()
        {
        t += Time.deltaTime * speed;
        
        transform.position = Vector3.Lerp(pointA, pointB, t);
        
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