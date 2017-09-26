using UnityEngine;
using UnityEngine.Events;
using System.Collections;

namespace Valve.VR.InteractionSystem{

public class OnClickSound : MonoBehaviour
{
	public AudioClip sound;
	


	void OnMouseDown ()
	{
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play();
		
	}
			
	private void OnTriggerEnter( Collider other )
	{
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Play();
				
	}
}
}