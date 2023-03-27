using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollidedWithBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball") || collision.gameObject.CompareTag("Pin"))
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
