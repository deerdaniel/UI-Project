using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{

    private float uperBound = 30;
    private float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.z > uperBound)
        {
            Destroy(gameObject);
        }else if ( transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
