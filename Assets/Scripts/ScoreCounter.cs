using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public bool flg = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flg)
        {
            PlusScoreCount();
        }
    }

    public void PlusScoreCount()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void MinusScoreCount()
    {
        score--;
        scoreText.text = score.ToString();
    }

    public void ChangeFlg()
    {
        flg = !flg;
    }
}
