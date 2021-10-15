using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrondScroller : MonoBehaviour
{
    public Transform camera;
    public List<MoveBackground> backgroundPieces;
    public float speed;
    public Transform trackedObject;
    Vector3 lastpos;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        backgroundPieces = new List<MoveBackground>(GetComponentsInChildren<MoveBackground>());
        transform.position = new Vector3(trackedObject.position.x + offset,transform.position.y,transform.position.z);
        lastpos = transform.position;
    }
    private void Update()
    {
        transform.position = new Vector3(trackedObject.position.x + offset, transform.position.y, transform.position.z);
        foreach (MoveBackground m in backgroundPieces)
        {

            m.actualSpeed = m.distanceScaler *(transform.position.x-lastpos.x)*speed;
            m.tick();

        }
        lastpos = transform.position;
    }
    // Update is called once per frame
}