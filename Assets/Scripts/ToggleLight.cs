using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem{

public class ToggleLight : MonoBehaviour
{
	public Light myLight;



	void OnMouseDown ()
	{
		myLight.enabled = !myLight.enabled;
	}


	private void OnTriggerEnter( Collider other )
	{
				myLight.enabled = !myLight.enabled;
	}
}
}