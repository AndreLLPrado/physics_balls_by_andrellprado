using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall_scripit : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
        if (transform.position.x <= -20)
        {
            direction = direction * -1;
        }

        if (transform.position.x >= 20)
        {
            direction = direction * -1;
        }
    }
}
