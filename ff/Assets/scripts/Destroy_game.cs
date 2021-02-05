using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_game : MonoBehaviour
{
    GameObject destoyerobj;
    // Start is called before the first frame update
    void Start()
    {
        destoyerobj = GameObject.Find("Destoyer");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < destoyerobj.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
