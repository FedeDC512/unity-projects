using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public GameObject bone;
    public GameObject carrot;
    public GameObject apple;
    public int bullet = 0;
    public GameObject mushText;
    public static bool poisoned = false;

    private KeyCode right = KeyCode.D;
    private KeyCode left = KeyCode.A;

    void Update(){
        if (Input.GetKey(right) && transform.position.x < 19) transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (Input.GetKey(left) && transform.position.x > -19) transform.Translate(Vector3.left * Time.deltaTime * speed); 
        if (Input.GetKeyDown(KeyCode.Space)) CheckBullet();

        if (Input.GetKeyDown(KeyCode.Keypad1)) bullet = 0; //bone
        if (Input.GetKeyDown(KeyCode.Keypad2)) bullet = 1; //carrot
        if (Input.GetKeyDown(KeyCode.Keypad3)) bullet = 2; //apple
    }

    void CheckBullet(){
        if (bullet == 0){
            Instantiate(bone,
                transform.position + new Vector3(0, 2, 0),
                bone.transform.rotation);
        }
        else if (bullet == 1){
            Instantiate(carrot,
                transform.position + new Vector3(0, 2, 0),
                carrot.transform.rotation);
        }
        else if (bullet == 2){
            Instantiate(apple,
                transform.position + new Vector3(0, 2, 0),
                apple.transform.rotation);
        }
    }

    private void SwapMovement(){
        //if press A we go right, if press D we go left
        KeyCode temp = right;
        right = left;
        left = temp;
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Mushroom")){
            poisoned = true;
            GameManager.instance.spawnedMush = false;
            SwapMovement();
            Destroy(other.gameObject);
            mushText.gameObject.SetActive(true);
        }
        else if (other.CompareTag("Antidote")){
            poisoned = false;
            GameManager.instance.spawnedMush = false;
            SwapMovement();
            Destroy(other.gameObject);
            mushText.gameObject.SetActive(false);
        }
    }
}
