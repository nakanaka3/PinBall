using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //スコアを表示するテキスト用の変数の宣言
    private GameObject scoreText;
    //スコアを計算するための変数の宣言と初期値の定義
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }
    // Update is called once per frame
    void Update()
    {

    }
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision others)
    {
        // タグによってスコアを変える
        if (others.gameObject.tag == "SmallStarTag")
        {
            this.score += 5;
        }
        else if (others.gameObject.tag == "LargeStarTag")
        {
            this.score += 10;
        }
        else if (others.gameObject.tag == "SmallCloudTag")
        {
            this.score += 15;
        }
        else if (others.gameObject.tag == "LargeCloudTag")
        {
            this.score += 20;
        }

        //scoreTextにスコアを表示
        this.scoreText.GetComponent<Text>().text = "Score=" + this.score;
    }
}