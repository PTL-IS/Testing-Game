using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBtnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public void gameMenuBtn()
    {
        SceneManager.LoadScene("Game Menu");
    }

    public void mainMenuBtn()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void map1MenuBtn()
    {
        SceneManager.LoadScene("Map 1");
    }
}
