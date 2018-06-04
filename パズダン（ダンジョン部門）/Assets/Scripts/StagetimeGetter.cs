using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StagetimeGetter : MonoBehaviour {

    public string filename;
    public UnityEngine.UI.Text text;
    private int clear_time;
	// Use this for initialization
	void Start () {
		FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
        BinaryReader reader = new BinaryReader(file);
        file.Seek(0, SeekOrigin.Begin);
        clear_time = reader.ReadInt32();
        text.text = (clear_time / 600).ToString() + "'" + (clear_time % 600 / 10).ToString() + "''" + (clear_time % 10).ToString(); 
    }
    
    public int Time_get()
    {
        return clear_time;
    }

}
