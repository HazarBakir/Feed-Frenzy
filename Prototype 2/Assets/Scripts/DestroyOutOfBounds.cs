using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -10;
    PlayerController player;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound || transform.position.x > topBound || transform.position.x < -topBound)
        {
            if (player.lives > 0)
            {
                player.lives -= 1;
                Debug.Log("lives: " + player.lives);
                Destroy(gameObject);
            }
            if (player.lives <= 0)
            {
                Debug.Log("Game Over!");
                Destroy(gameObject);
            }
        }
    }
}
