using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInst : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //No01.ボタンを押したときに弾を生成する
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //生成するにはInstatiateを使う
            //弾の発射する位置を付け加える
            Instantiate(bulletPrefab,transform.position,transform .rotation);
            Debug.Log("発射");
        }
    }
}
