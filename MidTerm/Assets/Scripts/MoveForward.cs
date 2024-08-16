using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z < -15){
            GameManager.instance.GameOver(); 
            Destroy(gameObject);
        }
        if(transform.position.z > 50) Destroy(gameObject);
    }
}
