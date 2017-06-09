using UnityEngine;

public class Hole : MonoBehaviour
{

	public bool showText = false;

	void OnTriggerEnter2D (Collider2D col)
	{

		if (col.gameObject.tag == "Weight") {

			Destroy (col.gameObject);
			showText = true;

			
		}

	}


	void OnGUI ()
	{
		if (showText == true) {
			GUI.Label (new Rect (200, 100, 0, 0), "Success!");
		}
	}


}
