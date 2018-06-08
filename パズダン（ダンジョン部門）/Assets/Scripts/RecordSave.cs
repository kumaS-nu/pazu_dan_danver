using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RecordSave : MonoBehaviour {
    public StagetimeGetter stage1;
    public StagetimeGetter stage2;
    public Totaltime totaltime;
    private string str_reco;
    private string[,] reco;
    private int date_num;
    public InputManager pname;
	// Use this for initialization
	void Start () {
        int len;
        date_num = 0;
        reco = new string[5,4];
      
        FileStream file = new FileStream("Record.dat", FileMode.OpenOrCreate, FileAccess.Read);
        BinaryReader reader = new BinaryReader(file);
        file.Seek(0, SeekOrigin.Begin);
        int j = 0;
        try { str_reco = reader.ReadString(); }
        catch (EndOfStreamException){ goto last; }
        

        len = str_reco.Length;

        int first = 0;
        int end = len;
        int k = 0;
        for (int i = 0; i < len; i++)                                         //ファイル読み取り
        {
            if(i != 0 && str_reco[i] == ',' && str_reco[i - 1] == ',')
            {
                string temp = "";
                end = i - 1;
                for(int n = first; n < end; n++)
                {
                    temp += str_reco[n];
                }
                
                reco[j,k] = temp;
                j++; k = 0;
                first = i + 1;
            }else if(str_reco[i] == ',' && str_reco[i + 1] != ',')
            {
                string temp = "";
                end = i;
                for(int n = first; n < end; n++)
                {
                    temp += str_reco[n];
                }
                reco[j,k] = temp;
                k++;
                first = i + 1;
            }
        }
        date_num = j;
        last:
        Debug.Log("Loaded:" + str_reco);
        file.Close();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Submit") != 0 )
        {
            string[,] new_reco;
            new_reco = new string[6,4];
           
            int[] total = new int[date_num];
            int rank = 1;

            for(int i = 0; i < date_num; i++)                                  // 順位測定
            {
                total[i] = 0;
                for(int j = 0; j < reco[i,3].Length; j++)
                {
                    int num = reco[i,3][reco[i,3].Length - j - 1] - '0';
                    for(int m = 0; m < j; m++)
                    {
                        num *= 10;
                    }
                    total[i] += num;
                }
                if (total[i] < totaltime.Time_get())
                    rank++;
            }
            Debug.Log(rank);
            for(int i = 0; i <= date_num;i++)                           //ファイルに書き込む内容
            {
                if(rank  - 1 > i)
                {
                    for (int n = 0; n < 4; n++) {
                        new_reco[i,n] = reco[i,n]; }
                }else
                if(rank - 1 == i)
                {
                    new_reco[i,0] = pname.inputValue;Debug.Log(pname.inputValue);
                    new_reco[i,1] = stage1.Time_get().ToString();Debug.Log(stage1.Time_get().ToString());
                    new_reco[i,2] = stage2.Time_get().ToString();Debug.Log(stage2.Time_get().ToString());
                    new_reco[i,3] = totaltime.Time_get().ToString();Debug.Log(totaltime.Time_get().ToString());

                    for (int n = 0; n < 4; n++)
                    {
                        new_reco[i + 1, n] = reco[i, n];
                    }
                }else
                if(rank - 1 < i)
                {
                    for (int n = 0; n < 4; n++)
                    {
                        new_reco[i + 1, n] = reco[i, n];
                    }
                }
            }
            string str_write = "";
            int no;
            if (date_num == 5) { no = date_num; } else { no = date_num + 1; }
            for (int i = 0; i < no; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    str_write += new_reco[i,j];
                    str_write += ",";
                }
                str_write += ",";
            }

            FileStream file = new FileStream("Record.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(str_write);
            file.Close();
            Debug.Log("Saved:" + str_write);
        }
	}
}
