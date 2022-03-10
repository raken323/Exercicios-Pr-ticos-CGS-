using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luz : MonoBehaviour
{

 


    Light lt;
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.eulerAngles.x >= 5 && transform.eulerAngles.x < 175)
        {
            transform.Rotate(0.03f, 0, 0);
        }
        lt.color -= (Color.white / 0.03f) * Time.deltaTime;

    }
}
