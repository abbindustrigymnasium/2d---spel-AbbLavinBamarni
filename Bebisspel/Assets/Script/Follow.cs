﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour

 {   // The Target
    public Transform target;
   
void LateUpdate () {
    if(target == null) return;
    transform.position = new Vector3(target.position.x,
                                     transform.position.z);
}
}