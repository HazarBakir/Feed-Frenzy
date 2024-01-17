using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public PlayerController player;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            player.point += 1;
            Debug.Log("point = " + player.point);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
