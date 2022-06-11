using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision2D)
	{
		// 衝突した相手にBulletタグが付いているとき
		if (collision2D.gameObject.tag == "Bullet")
		{
			//オブジェクトが消える
			this.gameObject.SetActive(false);
			
		}
		Debug.Log("hit");
	}


}
