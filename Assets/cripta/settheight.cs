using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class settheight : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.CompareTag("coingrown"))

        {
            transform.localScale += new Vector3(1f, 1f, 1f);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("prepyatstvia"))
        { transform.localScale -= new Vector3(1f, 1f, 1f);
        }
    }
}
