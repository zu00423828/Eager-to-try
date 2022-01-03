using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class floor : MonoBehaviour {

    public Text Massage;
    public Button back;

    // Use this for initialization
    void Start ()
    {
        back.onClick.AddListener(backclick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {back.onClick.AddListener(backclick);
        if (collision.tag == "Player")
        {
            Massage.text = "GAMEOVER";
            back.gameObject.SetActive(true);
        }
    }
    static void backclick()
    {
        SceneManager.LoadScene("test");
    }
}
