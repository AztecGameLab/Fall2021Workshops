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

	public void tick()
    {
		x = transform.localPosition.x;
		x += actualSpeed;//* Time.deltaTime;
		transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
		if (x <= PontoDeDestino)
		{
			x = PontoOriginal;
			transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
		}
		else if (x >= PontoOriginal)
		{
			x = PontoDeDestino;
			transform.localPosition = new Vector3(x, transform.localPosition.y, transform.localPosition.z);
		}
	}
}
