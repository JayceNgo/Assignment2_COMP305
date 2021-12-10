using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)

    {
        if (collider.gameObject.name == "Player")
        {
            isFalling = true;
            Destroy(gameObject, 10);
        }
            
    }

    void Update()
    {
        if (isFalling)
        {
            downSpeed += Time.deltaTime/20;
            transform.position = new Vector3(transform.position.x,
                transform.position.y - downSpeed,
                transform.position.z);
        }

    }
}
