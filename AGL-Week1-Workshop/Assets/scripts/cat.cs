using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public Rigidbody2D catBody;
    bool movingRight = true;
    public float moveSpeed;
    bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        //print("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        catBody.velocity = new Vector3(moveSpeed, 0, 0);
        if (movingRight)
        {
            catBody.velocity = new Vector3(moveSpeed, 0, 0);
        }
        else
        {
            catBody.velocity = new Vector3(-moveSpeed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("dog")&&!collected) {
            
            //print("Contact");
            gameManager.instance.collectCat();
            SoundManager.Instance.PlayCatGrab();
            Destroy(gameObject);
            collected = true;
        }
        else
        {
            movingRight = !movingRight;

        }

        
    }
}
