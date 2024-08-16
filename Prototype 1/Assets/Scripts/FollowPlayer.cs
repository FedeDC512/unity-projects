using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 7, -7);
    private Vector3 offset2 = new Vector3(0, 7, 7);
    private Vector3 rotation = new Vector3(30, 0, 0);
    private bool buttonIsPressed = false;
    public int inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        if(inputID == 1) transform.position = player.transform.position + offset1;
        else transform.position = player.transform.position + offset2;
        transform.eulerAngles = player.transform.rotation.eulerAngles + rotation;
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire"+inputID)){
            //true -> front
            if(buttonIsPressed == false){
                buttonIsPressed = true;
                if(inputID == 1) offset1 = new Vector3(0, 2, 1.3f);
                else offset2 = new Vector3(0, 2, -1.3f);
                rotation = new Vector3(15, 0, 0);
            }
            //false -> back
            else{
                buttonIsPressed = false;
                if(inputID == 1) offset1 = new Vector3(0, 7, -7);
                else offset2 = new Vector3(0, 7, 7);
                rotation = new Vector3(30, 0, 0);
            }
        }
    }
}
