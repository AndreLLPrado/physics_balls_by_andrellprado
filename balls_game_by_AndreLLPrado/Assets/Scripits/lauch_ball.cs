using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lauch_ball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballPrefab;

    public float force;
    bool preparando = false;
    public int attempt;
    void Start()
    {
        attempt = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(attempt > 0)
        {
            if (Input.GetMouseButton(0))
            {
                preparando = true;
                if (force < 100.0f)
                {
                    force += 20 * Time.deltaTime;
                }
            }
            if (Input.GetMouseButtonUp(0) && preparando == true)
            {
                ballPrefab.GetComponent<ball>().intensity = force;
                Instantiate(ballPrefab, transform.position, GameObject.Find("camera").transform.rotation);
                force = 0.0f;
                preparando = false;
                attempt--;
            }
        }
        
    }
}
