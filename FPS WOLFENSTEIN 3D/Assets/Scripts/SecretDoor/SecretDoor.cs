using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretDoor : MonoBehaviour
{
    public GameObject secretDoor;
    

    void OnTriggerEnter(Collider other)
    {
        
        secretDoor.GetComponent<Animator>().enabled = true;
        this.GetComponent<BoxCollider>().enabled = false;
    }
}
