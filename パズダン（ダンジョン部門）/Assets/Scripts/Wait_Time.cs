using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Wait_Time : MonoBehaviour {
    private DateTime start;
    public int wait;
    private TimeSpan wait_time;
    public string str;

	// Use this for initialization
	void Start () {
        wait_time = new TimeSpan(0, 0, 0, wait / 1000, wait % 1000);
        start = DateTime.Now;
	}
	
	// Update is called once per frame
	void Update () {

        if (DateTime.Now - start > wait_time)
        {
            SceneManager.LoadScene(str);
        }
	}
}
