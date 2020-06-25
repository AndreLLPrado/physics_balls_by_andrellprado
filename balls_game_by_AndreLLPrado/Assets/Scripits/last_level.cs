using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class last_level : MonoBehaviour
{
     public GameObject gb;
    void Start()
    {
        //gb = GameObject.Find("finish_level");
        //GameObject.Find("fail").SetActive(false);
        active(false);

    }

    // Update is called once per frame
    void Update()
    {
        //checkAttempts();
    }

    public void active(bool t)
    {
        gb.SetActive(t);

        if (t == true)
        {
            GameObject.Find("player").GetComponent<moviment_player>().enabled = false;
        }
        else
        {
            GameObject.Find("player").GetComponent<moviment_player>().enabled = true;
        }
    }

    public void checkAttempts()
    {
        if (GameObject.Find("player").GetComponent<lauch_ball>().attempt <= 0)
        {
            GameObject.Find("player").GetComponent<moviment_player>().enabled = false;
            //GameObject.Find("fail").SetActive(true);
        }
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("Scenes/main_menu");

    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void tryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
