using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
	private Camera mainCamera;
	private float distanceMouseEixoZ;
	// Start is called before the first frame update
	void Start(){
		mainCamera = Camera.main;
		distanceMouseEixoZ = mainCamera.WorldToScreenPoint(transform.position).z;
	}

	void OnMouseDrag() {
		Vector3 screenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceMouseEixoZ);
		Vector3 wordPosition = mainCamera.ScreenToWorldPoint(screenPosition);
		transform.position = wordPosition;
	}
}
