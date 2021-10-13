using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool spawned = false;
    private float decay;

    // Update is called once per frame

    void Update()
    {
        // On spacebar press, send dog
        Reset();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            decay = 1f;
            spawned = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    private void Reset()
    {
        if (spawned && decay > 0)
        {
            decay -= Time.deltaTime;
        }
        if (decay < 0)
        {
            decay = 0;
            spawned = false;
        }
    }

}
