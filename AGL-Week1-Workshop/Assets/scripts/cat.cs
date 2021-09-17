using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public Rigidbody2D catBody;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello world");
    }

    // Update is called once per frame
    void Update()
    {
        catBody.velocity = new Vector3(1, 0, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("dog")) {
            print("Contact");
            gameManager.instance.collectCat();
            Destroy(gameObject);

        }

        
    }
}
