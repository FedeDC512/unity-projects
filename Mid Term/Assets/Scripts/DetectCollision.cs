using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            GameManager.instance.AddLives(-1);
            Destroy(gameObject);
        }
        else if (!other.CompareTag("Mushroom") || !other.CompareTag("Antidote")){
            Destroy(gameObject);
            Destroy(other.gameObject);
            VerifyAnimal(other);
        }
    }

    private void VerifyAnimal(Collider other)
    {
        if (gameObject.name.Contains("Bone") && other.CompareTag("Dog")) GameManager.instance.AddScore();
        else if (gameObject.name.Contains("Carrot") && other.CompareTag("Moose")) GameManager.instance.AddScore();
        else if (gameObject.name.Contains("Apple") && other.CompareTag("Cow")) GameManager.instance.AddScore();
        else GameManager.instance.AddLives(-1);
    }
}
