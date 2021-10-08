using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {



	public float speed;
	private float x;
	public float PontoDeDestino;
	public float PontoOriginal;




	// Use this for initialization
	void Start () {
		//PontoOriginal = transform.position.x;
	}
	
	// Update is called once per frame
	public void Move(float distance)
    {
		x = transform.position.x;
		x -= speed * distance;
		transform.position = new Vector3(x, transform.position.y, transform.position.z);



		if (x <= PontoDeDestino)
		{


			x = PontoOriginal;
			transform.position = new Vector3(x, transform.position.y, transform.position.z);
		}
	}
}
