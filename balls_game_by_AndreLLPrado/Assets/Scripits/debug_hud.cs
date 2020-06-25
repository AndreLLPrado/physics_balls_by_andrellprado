using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class debug_hud : MonoBehaviour
{
    // Start is called before the first frame update
    float force;
    int attempt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        force = GameObject.Find("launcherBall").GetComponent<lauch_ball>().force;
        attempt = GameObject.Find("launcherBall").GetComponent<lauch_ball>().attempt;

        GetComponentInChildren<Text>().text = "Lauch force: " + force.ToString() + "\n" +
                                              "Force in ball: " + (force * 15.0f).ToString() +
                                              "\nattempt: " + attempt.ToString();
    }
}
