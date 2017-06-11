using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hole : MonoBehaviour
{
	[SerializeField]
	Text successText;
	Text nextLevelText;

	private bool succeed = false;

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Return) && succeed == true) {
			Debug.Log ("Hey");
			nextLevel ();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Reset ();
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{

		if (col.gameObject.tag == "Weight") {

			Destroy (col.gameObject);
			ShowSuccessText ();

			succeed = true;


		}

	}

	void ShowSuccessText ()
	{
		successText.text = "SUCCESS!\nPress Enter to Continue";

	}

	void Reset ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	void nextLevel ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}



}
