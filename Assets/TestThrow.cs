using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestThrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.back * 75, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
