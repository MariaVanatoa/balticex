﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	public Transform target;
	public float smoothTime = 0.3F;
	public float posY;
	private Vector3 velocity = Vector3.zero;

	void Update() {
		//Moveing the camera with target=Player
		Vector3 targetPosition = target.TransformPoint (new Vector3 (0, posY, -10));
		transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime);
	}
}
