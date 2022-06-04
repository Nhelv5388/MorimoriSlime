using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Sceneを使うときに用いる

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameClearText;
    [SerializeField] GameObject gameOverText;
    public bool CameraStop = false;//カメラの停止を管理

    // Start is called before the first frame update
    void Start()
    {
        
    }


    void RestartScene()//初期地点にPlayerが戻る関数
    {
        //現在のシーンを取得する
        Scene thisScene = SceneManager.GetActiveScene();

        //現在のシーンを読み込む
        SceneManager.LoadScene(thisScene.name);
    }

    void TitleScene()
    {
        Scene thisScene = SceneManager.GetActiveScene();

         SceneManager.LoadScene("TitleScene");
    }

    public void GameOver()//ゲームオーバーになったときの関数
    {
        gameOverText.SetActive(true);
        //Invoke("TitleScene", 1.5f);
        Invoke("RestartScene", 1.5f);//１．５秒後にリスタート関数を呼ぶ
        //RestartScene();
    }

    public void GameClear()//ゲームクリアになったときの関数
    {
        gameClearText.SetActive(true);
        Invoke("RestartScene", 1.5f);//１．５秒後にリスタート関数を呼ぶ
        //RestartScene();
    }

}