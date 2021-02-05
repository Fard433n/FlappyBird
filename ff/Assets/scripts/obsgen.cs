using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsgen : MonoBehaviour
{
    public Transform GenPoint;
    public GameObject obstical;

    float difference;
    public float minDif, maxDif;

    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        difference = Random.Range(minDif, maxDif);
        if(transform.position.x < GenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + difference,  + Random.Range(1,4), transform.position.z);
            Instantiate(obstical, transform.position, transform.rotation);
        }
    }
}
