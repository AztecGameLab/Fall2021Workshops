using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public GameObject lassoPrefab;
    public Transform lassoHandle;
    public Rigidbody2D throwerRb;
    public float throwForce;
    Camera mainCam;
    public bool swinging;
    public Vector2 swingCenter;
    public LineRenderer lr;
    public LayerMask swingable;
    public float swingSpeed;
    public bool swingingRight;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire2"))
        {
            StopSwing();
            return;
        }
        if (swinging)
        {
            lr.SetPosition(0, throwerRb.position);
            lr.SetPosition(1, swingCenter);
            
            return;
        }        
        Vector3 mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition - new Vector3(0, 0, 10));
        Vector2 forceDir = (Vector2)mousePos;
        RaycastHit2D hit=Physics2D.Raycast(throwerRb.position, forceDir - throwerRb.position,1000,swingable);
        print(hit.transform.gameObject.name);
        if (hit == null)
            return;

        if (Input.GetButtonDown("Fire2"))
        {
            swingCenter = hit.point;
            StartSwing();
        }

    }
    private void FixedUpdate()
    {
        if (swinging)
        {
            transform.up = (swingCenter - (Vector2)transform.position).normalized;
            if(swingingRight)
                throwerRb.velocity = transform.right*swingSpeed;
            else
                throwerRb.velocity = -transform.right * swingSpeed;
        }
    }
    public void StartSwing()
    {
        lr.SetPosition(0, throwerRb.position);
        lr.SetPosition(1, swingCenter);
        lr.enabled = true;
        swinging = true;
        swingSpeed = throwerRb.velocity.magnitude;
        throwerRb.gravityScale = 0;
        swingingRight = swingCenter.x > transform.position.x;
        
    }
    public void StopSwing()
    {
        swinging = false;
        lr.enabled = false;
        transform.up = Vector3.up;
        throwerRb.gravityScale = 1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopSwing();


    }
}
