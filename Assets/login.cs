using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public GameObject begin;
    public InputField stid;
    public Text hight;
    public Button hit;
    public GameObject hitten;
    public Button esc;


	// Use this for initialization
	void Start ()
    {
       hight.text = PlayerPrefs.GetInt("hightscore").ToString();
        hit.onClick.AddListener(hitchick);
        esc.onClick.AddListener(escclick);
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}
    public void loginclick()
    {
        gameObject.SetActive(false);
        begin.SetActive(true);
    }

    void hitchick()
    {
        hitten.gameObject.SetActive(true);
    }

    void escclick()
    {
        hitten.gameObject.SetActive(false);
    }
}
