using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalComplete : MonoBehaviour
{
    public static int enemycount;
    public static int treasurecount;
    public GameObject enemyDisplay;
    public GameObject treasureDisplay;
    void Update()
    {
        enemyDisplay.GetComponent<Text>().text = "" + enemycount;
        treasureDisplay.GetComponent<Text>().text = "" + treasurecount;
    }
}
