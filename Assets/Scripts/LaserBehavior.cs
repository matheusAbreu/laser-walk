using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehavior : MonoBehaviour{
	Vector3 position, direction;
	GameObject laserObject;
	LineRenderer laser;
	List<Vector3> laserIndicies = new List<Vector3>();

	public LaserBehavior(Vector3 _position, Vector3 _direction, Material _material){
		this.laser = new LineRenderer();
		this.laserObject = new GameObject();
		this.laserObject.name = "Laser Beam";
		this.laserObject.tag = "Laser";
		this.position = _position;
		this.direction = _direction;

		this.laser = this.laserObject.AddComponent(typeof(LineRenderer)) as LineRenderer;
		this.laser.startWidth = 0.3f;
		this.laser.endWidth = 0.3f;
		this.laser.material = _material;
		this.laser.startColor = Color.blue;
		this.laser.endColor = Color.blue;

		CastRay(_position, _direction, this.laser);
	}

	void CastRay(Vector3 _position, Vector3 _direction, LineRenderer _laser){
		laserIndicies.Add(_position);
		Ray ray = new Ray(_position, _direction);
		RaycastHit hit;

		if(Physics.Raycast(ray, out hit, 30, 1)){
			CheckHit(hit, _direction, _laser);
		}else{
			laserIndicies.Add(ray.GetPoint(30));
			UpdateLaser();
		}

	}

	void UpdateLaser(){
		int count = 0;
		laser.positionCount = laserIndicies.Count;

		foreach(Vector3 indexies in laserIndicies){
			laser.SetPosition(count, indexies);
			count++;
		}
	}
	void CheckHit(RaycastHit hitInfo, Vector3 _direction, LineRenderer _laser){
		if (hitInfo.collider.gameObject.tag == "Target"){
			Destroy(GameObject.Find("Target"));
		}

		if(hitInfo.collider.gameObject.tag == "Mirror"){
			Vector3 startNewRay = hitInfo.point;
			Vector3 newDirection = Vector3.Reflect(_direction, hitInfo.normal);
			CastRay(startNewRay, newDirection, _laser);
		}else{
			laserIndicies.Add(hitInfo.point);
			UpdateLaser();
		}
	}
}
