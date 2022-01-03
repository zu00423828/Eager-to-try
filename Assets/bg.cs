using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bg : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        gameObject.transform.localPosition -= new Vector3(0, speed);
        
    }
    
}
