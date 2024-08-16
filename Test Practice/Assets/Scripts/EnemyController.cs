using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){
            gameManager?.GetComponent<GameManager>().GameOver();
        }
    }
}
