using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrondScroller : MonoBehaviour
{
    public Transform camera;
    public List<MoveBackground> backgroundPieces;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        scroll(transform.position.x - camera.position.x);
        transform.position = new Vector3(camera.position.x,transform.position.y,transform.position.z);

    }
    void scroll(float xdiff)
    {
        foreach(MoveBackground b in backgroundPieces)
        {
            b.Move(xdiff);
        }
    }
}
