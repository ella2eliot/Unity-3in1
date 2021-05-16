using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rb;
    GameObject center;
    public GameObject Indicator;
    bool hasPower = false;
    public float speed = 10;
    public float force = 15;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        center = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float value = Input.GetAxis("Vertical");
        Debug.Log(value);
        rb.AddForce(Vector3.forward * value * speed);
        //(0,0,1)向前,z座標(0,1,0)向上,y座標(1,0,0)向右,x座標
        Indicator.gameObject.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }

    void OnCollisionEnter(Collision col)
    {
        if ( col.gameObject.CompareTag("enemy") && hasPower )
        {
            Rigidbody enbody = col.gameObject.GetComponent<Rigidbody>();
            enbody.AddForce( (col.gameObject.transform.position - transform.position)*force, ForceMode.Impulse);
        }
        if (col.gameObject.CompareTag("food"))
        {
            hasPower = true;
            Indicator.gameObject.SetActive(true);
            Destroy(col.gameObject);
        }
    }
}
