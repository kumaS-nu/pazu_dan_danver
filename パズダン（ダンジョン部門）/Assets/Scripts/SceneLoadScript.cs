using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneLoadScript : MonoBehaviour {

    public string str;
    public bool is_Start;
    private TimeSpan allowTime = new TimeSpan(0, 0, 0, 1);
    private DateTime time;

    // Use this for initialization
    void Start () {
        time = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {
        if (allowTime < DateTime.Now - time)
        {
            if (Input.GetAxisRaw("Submit") != 0 && is_Start == true)
                Scene1();
        }
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
	}

    public void Scene1()
    {
        SceneManager.LoadScene(str);
#pragma warning restore CS0618 // Type or member is obsolete
    }

}

