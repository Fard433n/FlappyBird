using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformgen : MonoBehaviour
{
    public GameObject Platform;
    public Transform PlateformGenPoint;
    public float width;
    // Start is called before the first frame update
    void Start()
    {
        width = Platform.GetComponent<BoxCollider2D>().size.x;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < PlateformGenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + width, transform.position.y, transform.position.z);
            Instantiate(Platform, transform.position, transform.rotation);
        }
    }
}
