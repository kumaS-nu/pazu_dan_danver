using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Totaltime : MonoBehaviour {

    public StagetimeGetter stage1;
    public StagetimeGetter stage2;
    public UnityEngine.UI.Text text;
    private int totaltime;

	void Start () {
        totaltime = stage1.Time_get() + stage2.Time_get();
        text.text = (totaltime / 600).ToString() + "'" + (totaltime % 600 / 10).ToString() + "''" + (totaltime % 10).ToString();

    }
	
	public int Time_get()
    {
        return totaltime;
    }
}
