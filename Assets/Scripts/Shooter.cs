using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
	public Material material;
	LaserBehavior beam;

	// Update is called once per frame
	void Update(){
		Destroy(GameObject.Find("Laser Beam"));
		beam = new LaserBehavior(gameObject.transform.position, gameObject.transform.right, material);
	}
}
