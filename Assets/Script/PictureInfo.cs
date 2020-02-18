using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureInfo : MonoBehaviour {
	public GameObject plane;
	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		audiosource = gameObject.GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnPictureClicked ()
	{
		plane.SetActive (true);
		audiosource.Play ();
	}
}
