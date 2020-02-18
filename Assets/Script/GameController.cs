using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public GameObject StartCanvas;
	public GameObject RestartCanvas;
	public GameObject player;
	public GameObject FirstPoint;
	public GameObject StartPoint;
	public GameObject EndPoint, InstructionCanvas;

	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		player = player.transform.parent.gameObject;
		audiosource = gameObject.GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



public void EnterMuseum()
{
	// Disable the start UI.
		StartCanvas.SetActive(false);

	// Move the player to the play position.
		iTween.MoveTo(player,
		iTween.Hash(
				"position", FirstPoint.transform.position,
			"time", 3,
			"easetype", "linear"
		)
	);


	
}


// Reset the game sequence.
	public void EndVisit()
{
		// Disable the restart UI.
		RestartCanvas.SetActive(true);
		audiosource.Play ();

		// Move the player to the end position.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", EndPoint.transform.position,
				"time", 3,
				"easetype", "linear"
			)
		);


	}

	public void RestartVisit()
	{
		// Enable the start UI.
		StartCanvas.SetActive(true);

		//Set player to the StartPoint
		player.transform.position = StartPoint.transform.position;
		SceneManager.LoadScene ("MuseumNow");
	}

	public void DisableInstruction ()
	{
		InstructionCanvas.SetActive (false);
	}
}
