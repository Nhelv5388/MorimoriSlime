using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] LayerMask blockLayer;

    //No01.発射ポイントを作る
    //public Transform FirePoint;//弾を発射する位置を取得
    //public GameObject bulletPrefab;
    public enum DIRECTION_TYPE
    {
        STOP,
        RIGHT,
        LEFT,
    }

    void Shot()
    {
        // //No01.ボタンを押したときに弾を生成する
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        //     //生成するにはInstatiateを使う
        //     //弾の発射する位置を付け加える
        //     Instantiate(bulletPrefab,transform.position,transform .rotation);
        //     Debug.Log("発射");
        // }
    }


    DIRECTION_TYPE direction = DIRECTION_TYPE.STOP;//Playerの最初の状態（停止）

    Rigidbody2D rigidbody2D;
    [SerializeField] private float speed = 0;//プレイヤーの移動
    [SerializeField] private float jumpPower = 450;//ジャンプする初期値

    
    

    // Start is called before the first frame update
    void Start()
    {

        rigidbody2D = GetComponent<Rigidbody2D>();//Playerについているrigidbody2Dを取得
    }


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); //X座標を取得
        
        Shot();
        //No1.向きを決める
        if(x == 0)
        {
            //止まっている
            direction = DIRECTION_TYPE.STOP;

        }
        else if(x > 0)
        {
            //右へ移動
            direction = DIRECTION_TYPE.RIGHT;
        }
        else if(x < 0)
        {
            //左へ移動
            direction = DIRECTION_TYPE.LEFT;
        }
        /*
        //スペースキーが押されたらジャンプさせる  地面とくっついているときだけジャンプするようにする
        if(IsGround() && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        */
        if(Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            DownJump();
        }

    }

    
    void FixedUpdate()
    {
        
        //No1.向きを決めた後に速さを決める
        switch(direction)
        {
            case DIRECTION_TYPE.STOP:
                //速さは０
                speed = 0;
                break;
            case DIRECTION_TYPE.RIGHT:
                //速さは３
                speed = 3;
                transform.localScale = new Vector3(1,1,1);//右に体の向きを変える
                break;
            case DIRECTION_TYPE.LEFT:
                //速さはー３
                speed = -3;
                transform.localScale = new Vector3(-1,1,1);//左に体の向きを変える
                break;
        }
        rigidbody2D.velocity = new Vector2(speed,rigidbody2D.velocity.y);//velocityは速度
    }


    //ジャンプ関数
    void Jump()
    {
        //上に力を加える
        rigidbody2D.AddForce(Vector2.up * jumpPower);
        Debug.Log("Jump");
    }

    void DownJump()
    {
        //上に力を加える
        rigidbody2D.AddForce(Vector2.up * -jumpPower);
        Debug.Log("DownJump");
    }

    /*
    //地面にPlayerが着地しているのか判定する関数
    bool IsGround()
    {
        //始点ト終点の作成
        Vector3 leftStartPoint = transform.position - Vector3.right * 0.2f;
        Vector3 rightStartPoint = transform.position + Vector3.right * 0.2f;
         Vector3 endPoint = transform.position - Vector3.up * 0.7f;

        Debug.DrawLine(leftStartPoint, rightStartPoint);

        return Physics2D.Linecast(leftStartPoint,endPoint,blockLayer) || Physics2D.Linecast(rightStartPoint,endPoint,blockLayer);//pointに当たっているのがblockLayerならtrueを返す
    }
    */
    void OnTriggerEnter2D(Collider2D collision)//2Dのオブジェクトがぶつかったときに勝手に発動する関数
    {
        if(collision.gameObject.tag == "Wall")
        {
            Debug.Log("ゲームオーバー");
            gameManager.GameOver();
        }
        if(collision.gameObject.tag == "Finish")
        {
            Debug.Log("クリア");
            gameManager.GameClear();
        }
        //アイテムを受け取ったとき

        /*
        //敵に当たったとき
        if(collision.gameObject.tag == "Enemy")
        {
            //どこが当たったのか判定するためにEnemyManagerを取得
            EnemyManager enemy = collision.gameObject.GetComponent<EnemyManager>();//エネミーオブジェクトからエネミーマネージャーの中からエネミーを呼ぶ

            if(this.transform.position.y  + 0.3f > enemy.transform.position.y)//敵と自分のｙ座標を比較して、自分が上ならｔｒｕ　　（０．２程遊びを追加して判定を少し緩くする）
            {
                //上から踏んだら縦方向だけ移動を０にして、その場で少しジャンプする
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,0);
                Jump();
                //敵を削除
                enemy.DestroyEnemy();
            }
            else
            {
                //横から当たったらPlayerを削除
                Destroy(this.gameObject);
                gameManager.GameOver();

            }
        }
        */
    }

    


}
