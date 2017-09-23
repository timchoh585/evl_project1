using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour {

	public static ArrowManager Instance;

	public SteamVR_TrackedObject trackedObj;

	public GameObject bowString;

	public GameObject arrowStartPoint;

	public GameObject stringStartPoint;

	private GameObject currentArrow;

	public GameObject arrowPrefab;

	private bool isAttached = false;



	void Awake() {
		if ( null == Instance ) {
			Instance = this;
		}
	}



	void OnDestroy() {
		if ( this == Instance ) {
			Instance = null;
		}
	}



	// Use this for initialization
	void Start() {
		
	}



	// Update is called once per frame
	void Update() {
		AttachArrow();
		PullString();
	}



	private void PullString() {
		if ( isAttached ) {
			float dist = ( bowString.transform.position - trackedObj.transform.position ).magnitude;

			bowString.transform.localPosition = stringStartPoint.transform.localPosition + new Vector3( dist * 5f, 0f, 0f );


			var device = SteamVR_Controller.Input( (int) trackedObj.index );
			if ( device.GetTouchUp( SteamVR_Controller.ButtonMask.Trigger ) ) {

			}
		}
	}



	private void ReleaseArrow() {
		float dist = ( bowString.transform.position - trackedObj.transform.position ).magnitude;

		currentArrow.transform.parent = null;
		currentArrow.GetComponent<Arrow>().ArrowReleased();

		Rigidbody rb = currentArrow.GetComponent<Rigidbody>();
		rb.velocity = currentArrow.transform.forward * 10f * dist;
		rb.useGravity = true;

		currentArrow.GetComponent<Collider>().isTrigger = false;
		
		bowString.transform.position = stringStartPoint.transform.position;

		currentArrow = null;
		isAttached = false;
	}



	private void AttachArrow() {
		if ( null == currentArrow ) {
			currentArrow = Instantiate( arrowPrefab );
			currentArrow.transform.parent = trackedObj.transform;
			currentArrow.transform.localPosition = new Vector3( 0f, 0f, 0.342f );
			currentArrow.transform.localRotation = Quaternion.identity;
		}
	}



	public void AttachArrowToBow() {
		currentArrow.transform.parent = bowString.transform;
		currentArrow.transform.position = arrowStartPoint.transform.position;
		currentArrow.transform.rotation = arrowStartPoint.transform.rotation;

		isAttached = true;
	}
}