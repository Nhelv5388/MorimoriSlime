using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private float m_Speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //横に動く
        //No01.弾の動きを作る
        transform.position += new Vector3(m_Speed,0,0) * Time.deltaTime;
    }


    //弾が壁に当たったときの関数
    public void DestroyWall()
    {

    }
}
