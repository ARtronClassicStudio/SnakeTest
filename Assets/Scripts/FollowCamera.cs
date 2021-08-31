using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform point;
    public float speed = 0.1f;
    private float velocity = 0.0f;

    private void FixedUpdate()
    {
        transform.position = new Vector3
            (
            Mathf.SmoothDamp(transform.position.x, point.position.x, ref velocity, speed),
            Mathf.SmoothDamp(transform.position.y, point.position.y, ref velocity, speed),
            transform.position.z
            );
    }

}
