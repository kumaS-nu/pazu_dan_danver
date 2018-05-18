using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour {
    public int start_time;
    public int now_time;
    public int spend_time;
	// Use this for initialization
	void Start () {
		start_time = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 +
    DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;

    }

    // Update is called once per frame
    void Update () {
		now_time = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 +
    DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
        spend_time = now_time - spend_time;
    }
}
