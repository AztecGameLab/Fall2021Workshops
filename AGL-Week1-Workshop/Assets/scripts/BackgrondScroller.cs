using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrondScroller : MonoBehaviour
{
    public Transform camera;
    public List<MoveBackground> backgroundPieces;
    public float speed;
    Vector3 lastpos;
    // Start is called before the first frame update
    void Start()
    {
        backgroundPieces = new List<MoveBackground>(GetComponentsInChildren<MoveBackground>());
        lastpos = transform.position;
    }
    private void Update()
    {
        foreach(MoveBackground m in backgroundPieces)
        {

            m.actualSpeed = m.distanceScaler * speed;
            m.tick();
        }
    }
    // Update is called once per frame
}