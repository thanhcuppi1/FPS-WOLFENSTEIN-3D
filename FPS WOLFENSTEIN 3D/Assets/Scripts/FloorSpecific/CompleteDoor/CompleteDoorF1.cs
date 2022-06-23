using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

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
        GlobalComplete.nextfloor += 1;
        PlayerPrefs.SetInt("SceneToLoad", GlobalComplete.nextfloor);
        PlayerPrefs.SetInt("LivesSaved", GlobalLife.lifeValue);
        PlayerPrefs.SetInt("ScoreSaved", GlobalScore.scoreValue);
        PlayerPrefs.SetInt("AmmoSaved", GlobalAmmo.handgunAmmo);
        yield return new WaitForSeconds(2);
        completePanel.SetActive(true);
        yield return new WaitForSeconds(10);
        GlobalScore.scoreValue = 0;
        GlobalComplete.enemycount = 0;
        GlobalComplete.treasurecount = 0;
        SceneManager.LoadScene(GlobalComplete.nextfloor);
    }
}
