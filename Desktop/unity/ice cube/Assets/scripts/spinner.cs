using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    // Update is called once per frame
    [SerializeField] float xAngle = 0;       
    [SerializeField] float yAngle = 0;
    [SerializeField] float zAngle = 0;

    void Update()
    {
        yAngle = 1f;
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
