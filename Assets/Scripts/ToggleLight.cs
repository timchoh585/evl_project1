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


	private void OnHandHoverBegin( Hand hand )
	{

		if ( hand.GetStandardInteractionButton() )
		{
				myLight.enabled = !myLight.enabled;
		}

	}
}
}