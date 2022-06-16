using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmoClip;
    public AudioSource AmmoPickupSound;

    void OnTriggerEnter(Collider other)
    {
        fakeAmmoClip.SetActive(false);
        AmmoPickupSound.Play();
        GlobalAmmo.handgunAmmo += 10;
    }
}
