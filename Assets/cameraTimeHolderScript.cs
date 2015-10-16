using UnityEngine;
using System.Collections;


public class cameraTimeHolderScript : MonoBehaviour {
	//static float cameraTime;
	public float cameraTime2;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		//cameraTime = rb.position.z;
		cameraTime2 = rb.position.z;
	}
}
