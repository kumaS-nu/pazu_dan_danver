using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_swith : MonoBehaviour {
    public bool bridge_swich; // 橋スイッチのフラグ
    public bool bridge_sp;    // 隠しフラグ
    public Timer time;
    private Vector3 posi;
    public Vector3 this_posi;
	// Use this for initialization
	void Start () {
        bridge_swich = false;
        bridge_sp = false;
        this_posi = GameObject.Find("Bridge Swith").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        posi = GameObject.Find("unitychan").transform.position;
        if(Input.GetAxisRaw("Submit") == 1)
        {
            if((posi.x - this_posi.x)*(posi.x - this_posi.x) + (posi.z - this_posi.z) * (posi.z - this_posi.z) < 0.25 && posi.y - this_posi.y < 1 && posi.y - this_posi.y > -1)
            {if (time.spend_time < 300000)
                {
                    bridge_swich = true;
                }
                else
                {
                    bridge_sp = true;
                }
            }
        }
    }
}
