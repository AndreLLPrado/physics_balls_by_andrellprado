using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerReset : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 player_position;
    void Start()
    {
        player_position = GameObject.Find("player").gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("player").transform.position.y <= -30)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
