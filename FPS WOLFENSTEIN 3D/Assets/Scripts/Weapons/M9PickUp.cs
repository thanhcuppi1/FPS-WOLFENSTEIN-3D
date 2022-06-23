using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class M9PickUp : MonoBehaviour
{
    public GameObject realhandgun;
    public GameObject fakehandgun;
    public AudioSource handgunPickupSound;
    public GameObject pickUpDisplay;
    public GameObject pistolImage;
    void OnTriggerEnter(Collider other)
    {
        realhandgun.SetActive(true);
        fakehandgun.SetActive(false);
        handgunPickupSound.Play();
        this.GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "HANDGUN";
        pickUpDisplay.SetActive(true);
        pistolImage.SetActive(true);
    }

}
