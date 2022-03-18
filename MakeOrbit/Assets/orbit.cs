using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbit : MonoBehaviour
{
    public GameObject earth;
    public Vector3 vel = new Vector3(1, 2, 0);
    public Vector3 accel;
    public float n = 0f;
    public float dis = 0f;
    // Start is called before the first frame update
    void Start()
    {
        earth = GameObject.Find("Earth");   
    }

    // Update is called once per frame
    void Update()
    {
        accel = earth.transform.position - transform.position;
        dis = accel.magnitude;
        
        accel = 3f * accel * 1f / accel.magnitude;

        vel += accel * Time.deltaTime;
        transform.position += vel * Time.deltaTime;
    }
}
