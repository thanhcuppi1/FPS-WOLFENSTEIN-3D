using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealCollect : MonoBehaviour
{
    
    public AudioSource CollectSound;
    

    void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue = 100;
        CollectSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.SetActive(false);
    }
}
