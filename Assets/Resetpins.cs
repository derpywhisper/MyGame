using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetpins : MonoBehaviour
{
    private List<Vector3> positions;
    private List<Quaternion> rotations;
    public List<GameObject> pins;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var pin in pins)
        {
            //Get the position and rotation for each pin in our collection
            positions.Add(pin.transform.position);
            rotations.Add(pin.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    [ContextMenu("ResetPins")]
    public void ResetPins()
    {
        for(var i = 0; i < pins.Count; i++)
        {
            //set the pins back to the original position and rotation
            pins[i].transform.position = positions[i];
            pins[i].transform.rotation = rotations[i];
            //arrest all velocity
            var rb = pins[i].GetComponent<Rigidbody>();
            if (rb is not null)
            {
                rb.velocity = Vector3.zero;
            }
        }
    }
}
