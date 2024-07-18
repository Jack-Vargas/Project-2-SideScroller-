using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
//^^^^^^^^^look at that ^

public class Timer : MonoBehaviour
{
    public Text timeCountText;
    [SerializeField] float timeLimit;
    public GameObject WinText;
    public GameObject TWText;

    private int roundedTime;

    void Update()
    {
        roundedTime = (int)Mathf.RoundToInt(timeLimit);

        int minutes = roundedTime / 60;
        int seconds = roundedTime % 60;
        // the % thing is a "modulo" divides the time by 60 until the time cannot be divied by 60 any more... maybe... ?

        timeCountText.text = "Time" + minutes.ToString("D2") + ":" + seconds.ToString("D2");

        timeLimit += Time.deltaTime;

         if (timeLimit >= 20)
            {
            TWText.SetActive(true);
            }
    }

    public void StopTime()
    {
        WinText.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
