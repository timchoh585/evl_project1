using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickSound : MonoBehaviour {

	public AudioClip OnTouchSound;

	void OnTriggerEnter(Collider c){
		AudioSource.PlayClipAtPoint (OnTouchSound, new Vector2 (0, 0));
	}
}
