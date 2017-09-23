using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	private bool isAttached = false;

	private bool isFired = false;



	void Update() {
		if ( isFired && transform.GetComponent<Rigidbody>().velocity.magnitude > 5f ) {
			transform.LookAt( transform.position + transform.GetComponent<Rigidbody>().velocity );
		}
	}



	void OnTriggerStay() {
		AttachArrow();
	}



	void OnTriggerEnter() {
		AttachArrow();
	}



	public void ArrowReleased() {
		isFired = true;
	}



	private void AttachArrow() {
		var device = SteamVR_Controller.Input( (int) ArrowManager.Instance.trackedObj.index );
		if ( !isAttached && device.GetTouch( SteamVR_Controller.ButtonMask.Trigger ) ) {
			ArrowManager.Instance.AttachArrowToBow();
			isAttached = true;
		}
	}
}