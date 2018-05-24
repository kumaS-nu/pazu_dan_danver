using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Swith : MonoBehaviour {
    private Vector3 posi;
    public Vector3 this_posi;
    public string this_obj;
    public bool swi;
    private bool isPushReloadButton;
    private DateTime time;

    // ボタンが押されてから次にまた押せるまでの時間(秒)
    private TimeSpan allowTime = new TimeSpan(0, 0, 0,0,300);

    // 前回ボタンが押された時点と現在時間との差分を格納
    private TimeSpan pastTime;
    // Use this for initialization
    void Start () {
        this_posi = GameObject.Find(this_obj).transform.position;
        swi = false;
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
        swi = false;

        posi = GameObject.Find("unitychan").transform.position;
        if (!isPushReloadButton)
        {
            if (Input.GetAxisRaw("Submit") == 1)
            {
                if ((posi.x - this_posi.x) * (posi.x - this_posi.x) + (posi.z - this_posi.z) * (posi.z - this_posi.z) < 1 && posi.y - this_posi.y < 1 && posi.y - this_posi.y > -1)
                {
                    swi = true;
                    Debug.Log("pushed");
                    time = DateTime.Now;
                    isPushReloadButton = true;

                }
            }
                
        }
    }
}

