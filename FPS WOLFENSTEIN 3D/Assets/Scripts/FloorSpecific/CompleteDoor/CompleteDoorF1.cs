using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CompleteDoorF1 : MonoBehaviour
{
    public GameObject fadeOut;
    public GameObject completePanel;
    public GameObject thePlayer;
    public GameObject floorTimer;
    
    void OnTriggerEnter(Collider other)
    {
        floorTimer.SetActive(false);
        StartCoroutine(CompleteFloor());
        thePlayer.GetComponent<FirstPersonController>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        
    }

    IEnumerator CompleteFloor()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        completePanel.SetActive(true);
    }
}
