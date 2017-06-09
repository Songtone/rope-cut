using UnityEngine;

public class Rope : MonoBehaviour
{

	public Rigidbody2D chainHook;

	public GameObject chainPrefab;

	public int chains = 7;

	public Weight weight;


	// Use this for initialization
	void Start ()
	{

		GenerateRope ();

	}

	void GenerateRope ()
	{
		Rigidbody2D previousRB = chainHook;
		for (int i = 0; i < chains; i++) {
			GameObject chain = Instantiate (chainPrefab, transform);
			HingeJoint2D joint = chain.GetComponent <HingeJoint2D> ();
			joint.connectedBody = previousRB;

			if (i < chains - 1) {
				previousRB = chain.GetComponent<Rigidbody2D> ();
			} else {
				weight.ConnectRopeEnd (chain.GetComponent <Rigidbody2D> ());
			}
		}
	}
	


}
