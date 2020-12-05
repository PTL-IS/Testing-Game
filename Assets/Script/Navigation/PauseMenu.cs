using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DecativateMenu();
        }
    }

    public void mainMenuBtn()
    {
        SceneManager.LoadScene("Main Menu");
    }

    void ActivateMenu ()
    {
        pauseMenuUI.SetActive(true);
    }

    void DecativateMenu ()
    {
        pauseMenuUI.SetActive(false);
    }
}
