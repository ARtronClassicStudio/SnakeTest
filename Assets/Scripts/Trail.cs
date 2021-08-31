using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    public Transform point;
    public ConfigSnake configSnake;

  

    private void Update()
    {
        if (configSnake.dead)
        {

            Vector3 vector = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0);
            float z = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, z - configSnake.trailAngle), Time.deltaTime * configSnake.trailRotationSpeed);
            transform.position += transform.right * configSnake.trailSpeed * Time.deltaTime;

        }
        else
        {

            Vector3 vector = point.position - transform.position;
            float z = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, z - configSnake.trailAngle), Time.deltaTime * configSnake.trailRotationSpeed);
            transform.position += transform.right * configSnake.trailSpeed * Time.deltaTime;

        }
    }
}
