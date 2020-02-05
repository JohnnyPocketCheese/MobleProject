using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{
    public int lastLevel;
    // Start is called before the first frame update
    void Start()
    {
        lastLevel = PlayerPrefs.GetInt("lastLevel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Retry()
    {
        SceneManager.LoadScene(lastLevel);
    }
}
