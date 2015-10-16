using UnityEngine;
using System.Collections;

public class TurnAroundY : MonoBehaviour {

	public Rigidbody rb;
	public float Speed = 100.0f;
	public Vector3 eulerAngleVelocity ;
	public Vector3 eulerAngle ;
	public Quaternion deltaRotation;
	public Quaternion newRotation;
	public Quaternion rot;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		//eulerAngleVelocity = new Vector3(0.0f, 1.0f, 0.0f);

	}
	
	// Update is called once per frame
	void Update () {
		//rb.rotation = new Quaternion(0.0f,speed,0.0f, 0.0f);
		//deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.deltaTime * Speed);
		//rb.MoveRotation(rb.rotation * deltaRotation);
		eulerAngle = new Vector3(0.0f, Time.time * Speed, 0.0f);
		newRotation = Quaternion.Euler(eulerAngle );
		rb.rotation = newRotation;
		rot = rb.rotation;

	}
}
