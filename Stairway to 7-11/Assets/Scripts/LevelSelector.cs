using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void LoadLevelOne()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
