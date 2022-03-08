using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject a;
    public GameObject b;

    public Vector3 ab;

    public float n = 0f;
    public float speed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = n * (a.transform.position - b.transform.position) + b.transform.position;
        n += speed;

        if (n <= 0)
        {
            speed = Mathf.Abs(speed);
        }
        if (n >= 1f)
        {
            speed = -Mathf.Abs(speed);
        }
    }

}
