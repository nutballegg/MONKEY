using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public GameObject pfb;
    public float arrowspeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject wee = Instantiate(pfb) as GameObject;
            wee.transform.position = transform.position;
            Rigidbody rb = wee.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
        }
    }
}
