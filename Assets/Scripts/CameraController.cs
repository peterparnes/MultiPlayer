using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	GameObject target;
	Vector3 offset;

	public void MyInit(GameObject player)
	{
		target = player;
		// offset = transform.position;
		offset = new Vector3(0.0f,0.5f,0.0f);
	}

	void Start ()
	{
	}
		
	void LateUpdate ()
	{
		if (target) {
			transform.position = target.transform.position + offset;
			transform.rotation = target.transform.rotation;
		}
	}
}