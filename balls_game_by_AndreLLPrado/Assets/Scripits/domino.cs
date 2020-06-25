using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domino : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "button")
        {
            Debug.Log(collision.gameObject.name + " Active!");
            collision.gameObject.GetComponent<button>().active();
        }
    }
}
