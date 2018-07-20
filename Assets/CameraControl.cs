using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
   public Transform playerTransform;
    public Vector3 offset;

	void Update () {
        transform.position = playerTransform.position + offset;
        transform.rotation = playerTransform.rotation;
    }
}
