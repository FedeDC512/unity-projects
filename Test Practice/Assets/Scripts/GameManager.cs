using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI hitCountText;
    public static int hitCount = 0;
    public GameObject player;
    //public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeText.SetText("Time: " + Math.Round(Time.time, 2));
        hitCountText.SetText("Hit Count: " + hitCount);
    }

    public void GameOver(){
        gameOverText.gameObject.SetActive(true);
        player.GetComponent<PlayerController>().enabled = false;
        //Time.timeScale = 0;
    }
}
