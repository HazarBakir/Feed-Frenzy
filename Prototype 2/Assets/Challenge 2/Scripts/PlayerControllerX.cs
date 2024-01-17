using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeElapsed;

    void Update()
    {
        if (timeElapsed <= 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeElapsed = 0.5f;
            }
        }
        else
        {
            timeElapsed -= Time.deltaTime;
        }



    }
}
