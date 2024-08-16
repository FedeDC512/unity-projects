using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;
    public string inputID;
    private bool activePlayerTwo = false;
    public Camera cam;
    public GameObject playerTwoText;
    public int coinCount;
    public int maxCoins;

    // Start is called before the first frame update
    void Start()
    {
        maxCoins = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Update is called once per frame
    void Update()
    {
        //check if player 2 is active
        if(Input.GetButtonDown("PlayerChange")){
            if(!activePlayerTwo){
                activePlayerTwo = true;
                if(inputID == " ") inputID = "2"; //actiate p2
                cam.rect = new Rect(0, 0, 0.5f, 1); //split screen
                playerTwoText.SetActive (true); //show text
            }
            else{
                activePlayerTwo = false;
                if(inputID == "2") inputID = " "; //disable p2 by removing "Horizontal2" and "Vertical2", the error is intentional
                cam.rect = new Rect(0, 0, 1, 1); //back to 1 player cam
                playerTwoText.SetActive (false); //hide text
            }
        }

        //Get the player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        //Move the vehicle forward based on vertical inputs
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotate the vehicle forward based on horizontal inputs
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
    }
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Collision happened");

        if(other.gameObject.CompareTag("Coin")){
            Destroy(other.gameObject);
            coinCount++;
            //other.gameObject.setActive(false);
            if(coinCount == maxCoins)
            {
                Debug.Log("You collected all "+ maxCoins +" coins!");
                GetComponent<PlayerController>().enabled = false;
            }
        }
        else
        {
            Debug.Log("You lost!");
        }
    }
}
