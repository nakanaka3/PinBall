using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //�X�R�A��\������e�L�X�g�p�̕ϐ��̐錾
    private GameObject scoreText;
    //�X�R�A���v�Z���邽�߂̕ϐ��̐錾�Ə����l�̒�`
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    }
    // Update is called once per frame
    void Update()
    {

    }
    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision others)
    {
        // �^�O�ɂ���ăX�R�A��ς���
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

        //scoreText�ɃX�R�A��\��
        this.scoreText.GetComponent<Text>().text = "Score=" + this.score;
    }
}