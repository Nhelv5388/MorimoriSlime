using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    private bool camera = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera = GameManager.instance.CameraStop;
        //ゲームオーバーになるまでマップを動かし続ける
        if(camera == false)
        {
            //横に徐々に移動する
        transform.Translate(-0.08f,0,0);
        }
        

        //横のバックグラウンドの座標よりも横になったら
        // if(transform.position.x < -20f)
        // {
        //     transform.position = new Vector3(0,0,0);
        // }
    }
}
