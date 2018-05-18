using System.Collections;
using UnityEngine;

public class BridgeDownS : MonoBehaviour {
    public bool pushed;
    public B_swith swe;

    private void Start()
    {
        pushed = false;
    }

    // Update is called once per frame
    void Update () {
		if(swe.bridge_swich == true && pushed == false)
        {
            GetComponent<Animation>().Play("BridgeDown"); // アニメーション再生
            pushed = true;
        }
	}
}
