using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour

{
 [SerializeField] private Vector3 pointA = new Vector3(-2, 0, 0); //the point where the gameObject starts
 [SerializeField] private Vector3 pointB = new Vector3(2, 0, 0); //the point where it is heading towards
 [SerializeField] private float speed = 1;
 private float t;

//makes the gameObject move from a point to another
 private void Update()
 {
 t += Time.deltaTime * speed;

 transform.position = Vector3.Lerp(pointA, pointB, t);
 }
}