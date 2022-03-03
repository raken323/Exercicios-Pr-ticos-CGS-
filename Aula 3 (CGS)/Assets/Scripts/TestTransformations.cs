using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransformations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        print(transform.position.x);
        print(transform.position.y);
        print(transform.position.z);

        print(transform.localEulerAngles.x);
        print(transform.localEulerAngles.y);
        print(transform.localEulerAngles.z);

        print(transform.lossyScale.x);
        print(transform.lossyScale.y);
        print(transform.lossyScale.z);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
