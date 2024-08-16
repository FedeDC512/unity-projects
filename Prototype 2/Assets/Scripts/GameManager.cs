using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private int lives = 3;
    public Text livesText;
    public Text scoreText;
    public GameObject[] hearts;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives = " + lives;
        scoreText.text = "Score = " + score;

        if(lives == 0){
            Destroy(hearts[0].gameObject);
        } else if(lives == 1){
            Destroy(hearts[1].gameObject);
        } else if(lives == 2){
            Destroy(hearts[2].gameObject);
        }
    }

    public void AddLives(int value){
        lives += value;
        if (lives <= 0){
            //Debug.Log("Game Over");
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0;
            //lives = 0;
        }
        //Debug.Log("Lives = " + lives);
    }

    public void AddScore(int value){
        score += value;
        //Debug.Log("Score = " + score);
    }
}
