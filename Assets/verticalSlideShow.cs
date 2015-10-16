using UnityEngine;
using System.Collections;

public class verticalSlideShow : MonoBehaviour {
	public float CameraTimeCopy;
	public Rigidbody rb;
	public Vector3 pos;
	private cameraTimeHolderScript myCameraTimeHolderScript;

	public float thresh = 125.0f;
	public float mult = 2.0f;
	public float data1;
	public float nearest;
	public float delta;
	public float adjustement;
	public float posCam;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		GameObject theCamera = GameObject.FindWithTag("myCameraTag");
		myCameraTimeHolderScript = theCamera.GetComponent<cameraTimeHolderScript>();
		pos = rb.position;
	}
	
	// Update is called once per frame
	void Update () {
		CameraTimeCopy = myCameraTimeHolderScript.cameraTime2;
	 	data1 = CameraTimeCopy * 10;
		nearest = ((int)( (data1 + 250.0f) / 500)) * 500.0f;
		delta = data1 - nearest;
		adjustement = 0.0f;
		if (delta > thresh) {
			adjustement = (delta - thresh) * mult;
		}
		if (delta < -thresh) {
			adjustement = (delta + thresh) * mult;
		}
		posCam = nearest + adjustement; // CameraTimeCopy * 10; // 100;
		pos.y = posCam;
		rb.position = pos;
	}
}
