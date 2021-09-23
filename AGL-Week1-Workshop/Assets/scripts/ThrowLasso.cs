using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowLasso : MonoBehaviour
{
    public GameObject lassoPrefab;
    public Transform lassoHandle;
    public Rigidbody2D throwerRb;
    public float throwForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Throw()
    {
        GameObject lassoInstance = Instantiate(lassoPrefab, lassoHandle.position, transform.rotation);
        lassoInstance.GetComponent<Lasso>().playerRb = throwerRb;
        lassoInstance.GetComponent<Rigidbody2D>().AddForce(lassoInstance.transform.right*throwForce, ForceMode2D.Impulse);
    }
}
