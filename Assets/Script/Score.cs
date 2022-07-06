using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public Text finalScore;
    public float scoreAmount;
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        score = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + "m";
        scoreAmount += score * Time.deltaTime;

        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            finalScore.text = scoreText.text;
            Destroy(scoreText);
        }
    }
}