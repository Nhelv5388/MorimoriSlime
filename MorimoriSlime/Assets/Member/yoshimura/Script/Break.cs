using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision2D)
	{
		// �Փ˂��������Player�^�O���t���Ă���Ƃ�
		if (collision2D.gameObject.tag == "Bullet")
		{
			// 0.2�b��ɏ�����
			//Destroy(gameObject, 0.2f);
			this.gameObject.SetActive(false);
			
		}
		Debug.Log("hit");
	}


}
