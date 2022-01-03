using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class massage : MonoBehaviour {

    public Text Massage;
    public static massage mg;
    public Button back;
	// Use this for initialization
	void Start ()
    {
        mg = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
    public  void print()
    {
        if (ScoreText.Score == 100 )
        {
            
            Massage.text = "GREAT";
            back.gameObject.SetActive(true);
            if (PlayerPrefs.GetInt("hightscore") <= ScoreText.Score)
            {
                PlayerPrefs.SetInt("hightscore", ScoreText.Score);
                PlayerPrefs.Save();
            }
           
        }
    }
    void backclick()
    {
        SceneManager.LoadScene("test");
        Destroy(GameObject.FindGameObjectsWithTag("answer")[0]);
        Destroy(GameObject.FindGameObjectsWithTag("answer")[1]);
    }
}
