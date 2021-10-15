using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour {



	public float distanceScaler;
	public float actualSpeed;
	private float x;
	public float PontoDeDestino;
	public float PontoDeDestinoLeft;
	public float PontoOriginal;




	// Use this for initialization
	void Start () {
		//PontoOriginal = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {


		

	}
	public void tick()
    {
		x = transform.position.x;
		x += actualSpeed * Time.deltaTime;
		transform.position = new Vector3(x, transform.position.y, transform.position.z);



		if (x <= PontoDeDestino)
		{


			x = PontoOriginal;
			transform.position = new Vector3(x, transform.position.y, transform.position.z);
		}
		else if (x >= PontoOriginal)
		{
			x = PontoDeDestino;
			transform.position = new Vector3(x, transform.position.y, transform.position.z);
		}
	}
}
