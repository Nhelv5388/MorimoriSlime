using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D collision2D)
	{
		// �Փ˂��������Bullet�^�O���t���Ă���Ƃ�
		if (collision2D.gameObject.tag == "Bullet")
		{
			//�I�u�W�F�N�g��������
			this.gameObject.SetActive(false);
			
		}
		Debug.Log("hit");
	}


}
