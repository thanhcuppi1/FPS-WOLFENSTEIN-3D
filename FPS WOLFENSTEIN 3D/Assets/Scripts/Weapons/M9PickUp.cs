using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M9PickUp : MonoBehaviour
{
    public GameObject realhandgun;
    public GameObject fakehandgun;
    public AudioSource handgunPickupSound;

    void OnTriggerEnter(Collider other)
    {
        realhandgun.SetActive(true);
        fakehandgun.SetActive(false);
        handgunPickupSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
    }

}
