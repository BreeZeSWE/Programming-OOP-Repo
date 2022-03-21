using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private Rigidbody targetRb;

    [SerializeField] private float sphereRotationRate = 0.5f;

    //private float time = 0f;

    // Start is called before the first frame update
    void Start() 
    {
        targetRb = GetComponent<Rigidbody>();

        Debug.Log("Name:" +  name);
        if (name == "Cube")
        {           
            targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        } 
    }

    private void FixedUpdate()
    { 
        
        if (name == "Sphere")
        {
            targetRb.transform.Rotate(0f, sphereRotationRate, 0f);
        }
    }
}
