using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Turn_Cylinder : MonoBehaviour {
    private int state;
    public Turn_Judge sylinder;
    private string play_name;
    private bool isPushReloadButton;

    // ボタンが押されてから次にまた押せるまでの時間(秒)
    private TimeSpan allowTime = new TimeSpan(0, 0, 0, 0, 500);

    // 前回ボタンが押された時点と現在時間との差分を格納
    private TimeSpan pastTime;

    private DateTime time;


    // Use this for initialization
    void Start () {
        state = 0;
        isPushReloadButton = false;
    }
	
	// Update is called once per frame
	void Update () {

        if (isPushReloadButton)
        {
            pastTime = DateTime.Now - time;
            if (pastTime > allowTime)
            {
                isPushReloadButton = false;
            }
        }

        if (sylinder.son == true)
        {
            if (!isPushReloadButton)
            {
                switch (state)
                {
                    case 0: play_name = "state1"; state = 1; Debug.Log("state1"); break;
                    case 1: play_name = "state2"; state = 2; Debug.Log("state2"); break;
                    case 2: play_name = "state3"; state = 3; Debug.Log("state3"); break;
                    case 3: play_name = "state4"; state = 0; Debug.Log("state4"); break;

                }
                GetComponent<Animation>().Play(play_name);
                time = DateTime.Now;
            }

        }
            
	}
}
