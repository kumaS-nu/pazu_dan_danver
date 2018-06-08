using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datenum_Judge : MonoBehaviour {

    public UnityEngine.UI.Text no1;
    public UnityEngine.UI.Text no2;
    public UnityEngine.UI.Text no3;
    public UnityEngine.UI.Text no4;
    public UnityEngine.UI.Text no5;
    public RecordShow temp;
    private int num;
	// Use this for initialization
	void Start () {
        StartCoroutine("Sleep");
	}
	IEnumerator Sleep()
    {
        yield return new WaitForSeconds(0.3f);

        num = temp.datenum;
        Debug.Log(num);
        if (num < 5)
            no5.text = "";
        if (num < 4)
            no4.text = "";
        if (num < 3)
            no3.text = "";
        if (num < 2)
            no2.text = "";
        if (num < 1)
            no1.text = "";
        
    }
	
}
