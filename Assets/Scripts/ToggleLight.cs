using UnityEngine;
using System.Collections;

public class ToggleLight : MonoBehaviour
{
	public Light myLight;



	void OnMouseDown ()
	{
		myLight.enabled = !myLight.enabled;
	}
}