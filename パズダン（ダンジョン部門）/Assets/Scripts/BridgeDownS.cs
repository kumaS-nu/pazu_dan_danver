using System.Collections;
using UnityEngine;

public class BridgeDownS : MonoBehaviour {
    public bool pushed;
    public B_swith swe;
    public string str;

    private void Start()
    {
        pushed = false;
    }

    // Update is called once per frame
    void Update () {
		if((swe.bridge_swich == true || swe.bridge_sp == true)&& pushed == false)
        {
            GetComponent<Animation>().Play(str); // アニメーション再生
            pushed = true;
        }
	}
}
