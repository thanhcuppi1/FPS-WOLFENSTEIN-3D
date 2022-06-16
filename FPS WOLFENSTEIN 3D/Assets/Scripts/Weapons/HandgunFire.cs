using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleflash;
    public AudioSource gunFire;
    public bool isFiring = false;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(FiringHandgun());
            }
            
        }
    }

    IEnumerator FiringHandgun()
    {
        isFiring = true;
        theGun.GetComponent<Animator>().Play("HandgunFire");
        muzzleflash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);
        muzzleflash.SetActive(false);
        yield return new WaitForSeconds(0.25f);
        theGun.GetComponent<Animator>().Play("New State");
        isFiring = false;
    }
}
