using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public int timeLeft = 120;
    public Text countDown;
    public int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("lastLevel", currentLevel);
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }

    // Update is called once per frame
    void Update()
    {
        countDown.text = ("" + timeLeft); //Showing the Score on the Canvas
        if (timeLeft <= 0)
        {
            
            SceneManager.LoadScene("Lose");
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }

    }
}
