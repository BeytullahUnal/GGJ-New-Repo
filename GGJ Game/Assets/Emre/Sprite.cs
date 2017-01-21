using UnityEngine;
using System.Collections;

public class Sprite : MonoBehaviour {
	SpriteRenderer muzzleFlashSprite;
	// Use this for initialization
	void Start () {
		muzzleFlashSprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame



	public IEnumerator Muzzle()
	{
		muzzleFlashSprite.enabled = true;
		yield return new WaitForSeconds (0.1f);
		muzzleFlashSprite.enabled = false;
	}
}
