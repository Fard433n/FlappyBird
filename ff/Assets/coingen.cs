using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coingen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coinobj;
    public Transform coinGenPoint;
    float distance;
    private void Update()
    {
        distance = Random.Range(-1, 4);
        if (transform.position.x < coinGenPoint.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + Random.Range(1,5),  distance, transform.position.z);
            Instantiate(coinobj, transform.position, transform.rotation);
        }
    }
}
