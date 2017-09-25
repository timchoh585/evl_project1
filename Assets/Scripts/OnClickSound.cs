using UnityEngine;
using System.Collections;

public class OnClickSound : MonoBehaviour
{
	public AudioClip sound;



	void OnMouseDown ()
	{
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play();
		
	}
}