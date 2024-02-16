using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float xRange = 20;
    private float horizontalInput;
    private float verticalInput;
    private float defaultCharacterSpeed = 15;
    // Update is called once per frame
    public GameObject projectilePrefab;
    void Update()
    {
        //Keep player in bounds
        if ( (transform.position.x < -xRange) )
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if ( transform.position.x > xRange)
        {
            transform.position = new Vector3(10, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * defaultCharacterSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.forward * defaultCharacterSpeed * verticalInput * Time.deltaTime);
    
        if (Input.GetKeyDown(KeyCode.Space) ) 
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
