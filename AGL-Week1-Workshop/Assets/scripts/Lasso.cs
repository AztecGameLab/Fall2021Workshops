using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasso : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public Rigidbody2D lassoRb;
    public float pullForce;
    // Start is called before the first frame update
    void Start()
    {
        if (!lassoRb)
        {
            lassoRb = GetComponent<Rigidbody2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerRb.AddForce((lassoRb.position - playerRb.position)*pullForce);
        print(collision.collider.gameObject.name);
        Destroy(gameObject);
    }
}
