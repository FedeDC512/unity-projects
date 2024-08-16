using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public float speed = 100.0f;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(enemy.transform.position * Time.deltaTime * speed);
        transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")){
            GameManager.hitCount++;
            Destroy(gameObject);
        }
    }
}