using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ConfigSnake configSnake;

    void FixedUpdate()
    {

        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float z = Mathf.Atan2(mouse.y,mouse.x) * Mathf.Rad2Deg; 
        transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.Euler(0,0, z - configSnake.headAngle),Time.deltaTime * configSnake.headRotationSpeed);
        transform.position += transform.right * configSnake.headSpeed * Time.deltaTime;


    }
}
