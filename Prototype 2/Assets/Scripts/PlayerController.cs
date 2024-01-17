using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float xRange = 10;
    public float zRangeNegative = -1;
    public float zRangePositive = 16;
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;

    public int point;
    public int lives = 3;

    void Update()
    {
        //keep the player in the bounds(not more than positionX = 10 or less than positionX = -10)
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {   //code duplication!!
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z >= zRangePositive)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangePositive);
        }
        if (transform.position.z <= zRangeNegative)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeNegative);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
