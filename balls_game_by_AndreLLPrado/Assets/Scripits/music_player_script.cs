using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_player_script : MonoBehaviour
{
    // Start is called before the first frame update
    private static music_player_script mp;
    void Awake()
    {
        if(mp == null)
        {
            mp = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
