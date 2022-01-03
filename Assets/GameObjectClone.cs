using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectClone : MonoBehaviour {

    public GameObject[] floors = new GameObject[3];////(1)
    private GameObject Clone;
    float timer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer > 0.3)////(2)
        {
            int i = Random.Range(0, 3);
            float j = Random.Range(-1.4f, 1.4f);
            float posx = j;
            Vector3 pos = new Vector3(posx, -2.0f, 0);
            Quaternion rot = new Quaternion(0, 0, 0, 0);
            Clone = (GameObject)Instantiate(floors[i], pos, rot);////(3)
           // Clone.AddComponent("answerMove");////(4)
            timer = 0;
        }
        GameObject[] AllObj = FindObjectsOfType(typeof(GameObject)) as GameObject[];
        foreach (GameObject obj in AllObj)
        {
            if (obj.transform.position.y > 20)
                Destroy(obj);////(5)
        }
    }
}
