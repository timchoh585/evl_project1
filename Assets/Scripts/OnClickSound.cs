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

	private void OnHandHoverBegin( Hand hand )
	{

			if ( hand.GetStandardInteractionButton() )
			{
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Play();
			}
				
	}
}
}