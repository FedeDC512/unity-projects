using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    Animator animator;

    void Start(){
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * Time.deltaTime * speed);
        if(horizontal == 0 && vertical == 0) animator.SetBool("Walking_dog", false);
        else animator.SetBool("Walking_dog", true);

        if (Input.GetButtonDown("Jump")) {
            // Launch a projectile from the player
            //animator.SetBool("Shooting_dog", true);
            Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);
            //animator.SetBool("Shooting_dog", false);
        }
    }
}
