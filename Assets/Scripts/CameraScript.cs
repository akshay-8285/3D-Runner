//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CameraScript : MonoBehaviour
//{
//    public Transform target;
//    public float smoothSpeed = 0.125f;
//    public Vector3 locationOffset;
//    public Vector3 rotationOffset;

//    void FixedUpdate()
//    {
//        // Follow the target's position with offset
//        Vector3 desiredPosition = target.position + locationOffset;
//        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
//        transform.position = smoothedPosition;

//        // Maintain a fixed rotation with rotation offset
//        Quaternion fixedRotation = Quaternion.Euler(rotationOffset);
//        transform.rotation = Quaternion.Lerp(transform.rotation, fixedRotation, smoothSpeed);
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 locationOffset = new Vector3(0, 2, -5);  // Default offset behind the player
    public Vector3 rotationOffset = new Vector3(10, 0, 0);  // Slight downward tilt

    void LateUpdate()
    {
        // Calculate the desired position with respect to the target and offset
        Vector3 desiredPosition = target.position + target.TransformDirection(locationOffset);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Calculate the desired rotation with respect to the target rotation and offset
        Quaternion desiredRotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
        Quaternion smoothedRotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothSpeed);
        transform.rotation = smoothedRotation;
    }
}
