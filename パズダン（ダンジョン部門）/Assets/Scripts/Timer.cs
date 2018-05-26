using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Timer : MonoBehaviour {
    public int start_time;
    public int now_time;
    public int spend_time;
    public UnityEngine.UI.Text show;

    // Use this for initialization
    void Start () {
		start_time = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 +
    DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;

    }

    // Update is called once per frame
    void Update () {
		now_time = DateTime.Now.Hour * 60 * 60 * 1000 + DateTime.Now.Minute * 60 * 1000 +
    DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
        spend_time = now_time - start_time;

        show.text = (spend_time / (60 * 1000)).ToString() + "'" + ((spend_time %(60 * 1000))/ 1000 ).ToString() + "''" + ((spend_time % 1000) / 100).ToString();
    }
}
