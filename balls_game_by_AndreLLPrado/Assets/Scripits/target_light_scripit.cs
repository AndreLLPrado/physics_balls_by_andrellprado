using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Rendering;
using UnityEngine;

public class target_light_scripit : MonoBehaviour
{
    // Start is called before the first frame update
    public float intensityMax;
    GameObject Light;
    bool invert = false;
    void Start()
    {
        Light = GameObject.Find("target");
    }

    // Update is called once per frame
    void Update()
    {
        if(invert == false)
        {
            Light.GetComponent<Light>().intensity += 1 * Time.deltaTime;
            if (Light.GetComponent<Light>().intensity >= intensityMax)
            {
                invert = true;
            }
        }
        
        else
        {
            Light.GetComponent<Light>().intensity -= 1 * Time.deltaTime;
            if (Light.GetComponent<Light>().intensity <= 0)
            {
                invert = false;
            }
        }

        

    }
}
