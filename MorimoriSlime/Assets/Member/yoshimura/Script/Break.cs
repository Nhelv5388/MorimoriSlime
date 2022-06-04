using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision2D)
	{
		// Õ“Ë‚µ‚½‘Šè‚ÉPlayerƒ^ƒO‚ª•t‚¢‚Ä‚¢‚é‚Æ‚«
		if (collision2D.gameObject.tag == "Bullet")
		{
			// 0.2•bŒã‚ÉÁ‚¦‚é
			//Destroy(gameObject, 0.2f);
			this.gameObject.SetActive(false);
			
		}
		Debug.Log("hit");
	}


}
