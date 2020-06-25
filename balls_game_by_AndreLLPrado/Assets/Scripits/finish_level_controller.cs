using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.UIElements;

public class finish_level_controller : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject gb;
    bool pauseMenu = false;
    void Start()
    {
        gb = GameObject.Find("finish_level");
        GameObject.Find("fail").SetActive(false);
        active(false);
        pauseMenu = false;
        GameObject.Find("pause_menu").SetActive(pauseMenu);

    }

    // Update is called once per frame
    void Update()
    {
        //checkAttempts();
        pauseGame();
        GameObject.Find("pause_menu").SetActive(pauseMenu);
    }

    public void active(bool t)
    {
        gb.SetActive(t);

        if(t == true){
            GameObject.Find("player").GetComponent<moviment_player>().enabled = false;
        }
        else
        {
            GameObject.Find("player").GetComponent<moviment_player>().enabled = true;
        }
    }

    public void checkAttempts()
    {
        if(GameObject.Find("player").GetComponent<lauch_ball>().attempt <= 0)
        {
            GameObject.Find("player").GetComponent<moviment_player>().enabled = false;
            GameObject.Find("fail").SetActive(true);
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

    public void pauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            pauseMenu = !pauseMenu;
        }

        if (pauseMenu == true)
        {
            Time.timeScale = 0;
            
        }

        if(pauseMenu == false)
        {
            Time.timeScale = 1;
        }
       
    }

    public void resumeGame()
    {
        pauseMenu = true;
    }
}
