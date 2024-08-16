using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 20.0f; 
    public float xRange = 15;
    public float zRange = 15;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange) transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        if(transform.position.x > xRange) transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(transform.position.z < 0) transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        if(transform.position.z > zRange) transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (Input.GetButtonDown("Jump")) {
             // Launch a projectile from the player
             Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }
    }
}
