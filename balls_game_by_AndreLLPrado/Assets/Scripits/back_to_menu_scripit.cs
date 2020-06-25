using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_to_menu_scripit : MonoBehaviour
{
   public void backToMenu()
    {
        SceneManager.LoadScene("Scenes/main_menu");
    }
}
