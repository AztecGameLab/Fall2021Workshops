using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.P))
        {
            if (PausePanel.active)
            {
                UnPause();
            }
            else
            {
                PausePanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void UnPause()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        UnPause();
        SceneManager.LoadScene("MainMenu");
    }
}
