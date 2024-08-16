using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour

{
    private int score = 0;
    private int lives = 3;
    public GameObject[] animals;
    public static GameManager instance;

    public TextMeshProUGUI gameOverTextLives;
    public TextMeshProUGUI gameOverTextAnimal;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI scoreText;
    
    private int mushVariable = 0;
    public bool spawnedMush = false;

    public GameObject mushroom;
    public GameObject antidote;

    void Update(){
        livesText.SetText("Lives: " + lives);
        scoreText.SetText("Score: " + score);
    }

    void Start(){
        instance = this;
        InvokeRepeating("spawnAnimal", 1, 3);
        InvokeRepeating("spawnMushroom", 1, 1);
    }

    void spawnAnimal(){
        int idx = Random.Range(0, animals.Length);
        Instantiate(animals[idx], 
            new Vector3(Random.Range(-15f,15f), 0.03f, 17),
            animals[idx].transform.rotation);
    }

    void spawnMushroom(){
        if(mushVariable > Random.Range(1,5)){
            if(PlayerController.poisoned == false && spawnedMush == false){
                spawnedMush = true;
                Instantiate(mushroom, new Vector3(Random.Range(-15f, 15f), 0.08f, 0), mushroom.transform.rotation);
            }
            else if (PlayerController.poisoned == true && spawnedMush == false){
                spawnedMush = true;
                Instantiate(antidote, new Vector3(Random.Range(-15f, 15f), 0.08f, 0), antidote.transform.rotation);
            }
            mushVariable = 0;
        }
        else mushVariable++;
    }

    public void AddLives(int value){
        lives += value;
        if (lives <= 0) GameOver();
    }

    public void AddScore(){ score ++; }

    public void GameOver(){
        if(lives <= 0) gameOverTextLives.gameObject.SetActive(true);
        else gameOverTextAnimal.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

}
