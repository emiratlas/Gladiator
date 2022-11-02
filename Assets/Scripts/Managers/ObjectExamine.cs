using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectExamine  : MonoBehaviour
{
    protected Vector3 posLastFame;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posLastFame = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            var delta = Input.mousePosition - posLastFame;
            posLastFame = Input.mousePosition;

            var axis = Quaternion.AngleAxis(-90f, new Vector3(transform.position.x,transform.position.y,transform.position.z)) * delta;

            transform.rotation = Quaternion.AngleAxis(delta.magnitude * 0.5f, axis) * transform.rotation;
        }
        
    }
}
