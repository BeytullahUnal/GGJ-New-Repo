using UnityEngine;
using System.Collections;
using Image=UnityEngine.UI.Image;

public class HPController : MonoBehaviour {
	Image Healtbar;
	public float tmpHealt;
	public float max =100;
	public GameObject MuzzleFlash;
	Sprite muzSpriteCompenent;

	void Start () {
		Healtbar=GameObject.Find ("Main Camera").transform.FindChild ("Canvas").FindChild ("Healtbar").GetComponent<Image>();
		muzSpriteCompenent = MuzzleFlash.GetComponent<Sprite> ();
		tmpHealt = max;
	}
	
	// Update is called once per frame
	void Update () {
		Healtbar.fillAmount = tmpHealt;
	}
	public virtual void changeHealth(int amount)
	{
		tmpHealt -= amount;

		StartCoroutine (muzSpriteCompenent.Muzzle ());
	}
	public void addHealth()
	{
		tmpHealt += 0.1f;
	}


	void OnTriggerEnter(Collider temas)
	{
		if (temas.gameObject.tag == "coin")
		{
			addHealth ();
			Destroy (temas.gameObject);
		}
	}

}
