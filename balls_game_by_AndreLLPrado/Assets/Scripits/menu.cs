using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Scenes/state_01");
        GameObject.Find("player").GetComponent<moviment_player>().enabled = true;
    }

    public void credits()
    {
        SceneManager.LoadScene("Scenes/credits_menu");
    }

    public void instructions()
    {
        SceneManager.LoadScene("Scenes/instructions_menu");
    }

    public void exit()
    {
        Application.Quit();
    }
}
