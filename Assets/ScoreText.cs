using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text Score_text;
    public static int Score = 0;
    public static ScoreText instance;
    

    // Use this for initialization
    void Start() {
        instance = this;
        Score = 0;
    }

    // Update is called once per frame
    void Update() {
        
   }
    public void AddScore()

    {
        
            Score = Score+10;
            Score_text.text = ""+Score; // 更改ScoreText的內容
        
    }
                 
}
