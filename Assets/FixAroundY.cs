using UnityEngine;
using System.Collections;

public class FixAroundY : MonoBehaviour {

	public Rigidbody rb;
	public Vector3 eulerAngle ;
	public Quaternion newRotation;
	public float Speed = -100.0f;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		eulerAngle = new Vector3(60.0f, 180.0f - Time.time * Speed, 0.0f);
		newRotation = Quaternion.Euler(eulerAngle );
	}
	
	// Update is called once per frame
	void Update () {

		rb.rotation = newRotation;

	}
}
