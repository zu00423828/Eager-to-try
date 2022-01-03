using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour {

    public GameObject cloud_one;
    public GameObject cloud_two;
    public float timer = 0;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer > 2.0f)
        {
            cloud_one.gameObject.SetActive(false);
            cloud_two.gameObject.SetActive(true);
            timer = 0;
        }
        else if(timer >1.0f)
        {
            cloud_one.gameObject.SetActive(true);
            cloud_two.gameObject.SetActive(false);
            
        }
        

        
	}
}
