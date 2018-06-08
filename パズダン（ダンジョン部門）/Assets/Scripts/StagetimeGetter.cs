using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StagetimeGetter : MonoBehaviour {

    public string filename;
    public UnityEngine.UI.Text text;
    private int clear_time;
    private string str;
	// Use this for initialization
	void Start () {
		FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read);
        BinaryReader reader = new BinaryReader(file);
        file.Seek(0, SeekOrigin.Begin);
        str = reader.ReadString();

        clear_time = 0;
        for (int j = 1; j <= str.Length; j++)
        {
            int num = str[str.Length - j] - '0';
            for (int m = 1; m < j; m++)
            {
                num *= 10;
            }
            clear_time += num;
        }

            text.text = (clear_time / 600).ToString() + "'" + (clear_time % 600 / 10).ToString() + "''" + (clear_time % 10).ToString(); 
    }
    
    public int Time_get()
    {
        return clear_time;
    }

}
