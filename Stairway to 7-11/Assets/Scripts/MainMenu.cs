using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int lastLevel;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
        lastLevel = PlayerPrefs.GetInt("lastLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void ContinueGame()
    {
        SceneManager.LoadScene(lastLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
        GetComponent<Canvas>().enabled = false;
    }
}
