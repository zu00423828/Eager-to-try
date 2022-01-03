using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class choose : MonoBehaviour
{

    public Dropdown chosses;
    public GameObject link;
    public GameObject login;
    public static int chooseindex;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        chooseindex = chosses.value;
    }
    public void choseclick()
    {
        chooseindex = chosses.value;
        gameObject.SetActive(false);
        link.SetActive(true);
    }
    public void backclick()
    {
        gameObject.SetActive(false);
        login.SetActive(true);
    }
}
