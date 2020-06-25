using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim : MonoBehaviour
{
    // Start is called before the first frame update
    public float distanceRay;
    private LineRenderer laser_aim;
    //private LineRenderer laser_aim2;
    void Start()
    {
        laser_aim = GetComponent<LineRenderer>();
        laser_aim.SetWidth(0.1f, 0.1f);
        //laser_aim2.SetWidth(0.1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit ray;
        if(Physics.Raycast(transform.position, transform.forward, out ray, distanceRay))
        {
            laser_aim.SetPosition(1,new Vector3(0 , 0, ray.distance));
            //laser_aim.SetPosition(2, new Vector3(0, 0, -distanceRay));
        }
        else
        {
            laser_aim.SetPosition(1, new Vector3(0, 0, distanceRay));
            //laser_aim.SetPosition(2, new Vector3(0, 0, 0));
        }
    }
}
