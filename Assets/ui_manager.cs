using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_manager : MonoBehaviour
{
    public Text ScoreOutput;
    public float score = 0;

    // Update is called once per frame
    void Update()
    {
        ScoreOutput.text = score.ToString();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
        }
    }

    public void IncrimentScore()
    {
        score += 10;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
