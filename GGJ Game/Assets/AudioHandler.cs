using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour {

	AudioSource PlayerAudio; 
	public AudioClip Aygaz;
	public AudioClip Loop;
	void Awake () 
	{
		PlayerAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	IEnumerator Start()
	{
		PlayerAudio.Play ();
		yield return new WaitForSeconds (PlayerAudio.clip.length);
		PlayerAudio.clip = Loop;
		PlayerAudio.loop = true;
		PlayerAudio.volume += 0.3f;
		PlayerAudio.Play ();
	}

}
