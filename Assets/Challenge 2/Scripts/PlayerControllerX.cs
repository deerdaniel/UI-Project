using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float _nextShot = 0.15f;
    private float _fireDelay = 0.5f;
    
    // Update is called once per frame
    void Start()
    {
          
    }
    void Update()
    {

        DogFire();
    }
    private void DogFire()
    {
       
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space) && _nextShot <= Time.time)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                _nextShot = Time.time + _fireDelay;
            }
        
    }
}
