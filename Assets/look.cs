using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public float speed=20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float value=Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * value * speed * Time.deltaTime);
    }
}
