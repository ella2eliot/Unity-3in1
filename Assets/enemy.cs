using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    public float speed=10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        rb.AddForce( (player.transform.position - transform.position).normalized * speed);

    }
}
