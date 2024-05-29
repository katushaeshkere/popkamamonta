using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlerpollice : MonoBehaviour
{
    private int speed = 20;
    private int rotationSpeed = 80;
    private float horizontal;
    private float vertical;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed* vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed* horizontal);
        


    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("coingrown"))
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("vse rabotaet");  
    }
}
