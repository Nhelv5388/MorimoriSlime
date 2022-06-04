using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision2D)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (collision2D.gameObject.tag == "Bullet")
		{
			// 0.2秒後に消える
			//Destroy(gameObject, 0.2f);
			this.gameObject.SetActive(false);
			
		}
		Debug.Log("hit");
	}


}
