using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 directionBall;
    public Vector3 forceBall;
    public float intensity;
    void Start()
    {
        GameObject player;
        player = GameObject.Find("camera");

        GetComponent<Rigidbody>().AddForce(player.transform.forward * 15.0f * intensity);

 
    }

    void Update()
    {
        if (transform.position.y < -10)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        if (collision.gameObject.tag == "target")
        {
            Debug.Log("Acertou!");
            if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 10)
            {
                GameObject.Find("Canvas").GetComponent<last_level>().active(true);
            }
            else
            {
                GameObject.Find("Canvas").GetComponent<finish_level_controller>().active(true);
            }
            
            
        }
    }
}
