using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bird_movements : MonoBehaviour
{
    Rigidbody2D myrigidbody;

    public float speed;
    public float jumpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        myrigidbody.velocity = new Vector2(speed, myrigidbody.velocity.y);
        if(Input.anyKeyDown)
        {
            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, jumpSpeed);
        }
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obsticles")
        {
            SceneManager.LoadScene(1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coins")
        {
            Debug.Log("fff");
            Destroy(collision.gameObject);
        }
    }
}
