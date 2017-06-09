using UnityEngine;

public class Cutting : MonoBehaviour
{


	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButton (0)) {
			RaycastHit2D cut = Physics2D.Raycast (Camera.main.ScreenToWorldPoint (Input.mousePosition), Vector2.zero);

			if (cut.collider != null) {
				if (cut.collider.tag == "chain") {
					Destroy (cut.collider.gameObject);
				}
			}
		}
		
	}
}
