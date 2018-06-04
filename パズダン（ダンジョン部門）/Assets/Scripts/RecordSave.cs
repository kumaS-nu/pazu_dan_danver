using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RecordSave : MonoBehaviour {
    public StagetimeGetter stage1;
    public StagetimeGetter stage2;
    public Totaltime totaltime;
    private string str_reco;
    private List<string>[] reco;
    private int datenum;
	// Use this for initialization
	void Start () {
        int len;
        
        reco = new List<string>[5];
        for(int i = 0;i < 5; i++)
        {
            reco[i] = new List<string>(4);
        }
        FileStream file = new FileStream("Record.cvs", FileMode.Open, FileAccess.Read);
        BinaryReader reader = new BinaryReader(file);
        file.Seek(0, SeekOrigin.Begin);
        str_reco = reader.ReadString();

        len = str_reco.Length;

        int first = 0;
        int end = len;
        int j = 0;
        int k = 0;
        for (int i = 0; i < len; i++)                                         //ファイル読み取り
        {
            if(str_reco[i] == ',' && str_reco[i - 1] == ',')
            {
                string temp = "";
                end = i - 1;
                for(int n = first; n < end; n++)
                {
                    temp += str_reco[n];
                }
                reco[j][k] = temp;
                j++; k = 0;
                first = i + 1;
            }else if(str_reco[i] == ',')
            {
                string temp = "";
                end = i;
                for(int n = first; n < end; n++)
                {
                    temp += str_reco[n];
                }
                reco[j][k] = temp;
                k++;
                first = i + 1;
            }
        }
        datenum = j;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Submit") != 0)
        {
            List<string>[] new_reco;
            new_reco = new List<string>[6];
            for (int i = 0; i < 6; i++)
            {
                new_reco[i] = new List<string>(4);
            }
            int[] total = new int[datenum];
            int rank = 1;

            for(int i = 0; i < datenum; i++)                                  // 順位測定
            {
                total[i] = 0;
                for(int j = 0; j < reco[i][3].Length; j++)
                {
                    int num = reco[i][3][reco[i][3].Length - j] - '0';
                    for(int m = 0; m < j; m++)
                    {
                        num *= 10;
                    }
                    total[i] += num;
                }
                if (total[i] < totaltime.Time_get())
                    rank++;
            }
            for(int i = 1; i <= datenum;i++)                           //ファイルに書き込む内容
            {
                if(rank > i)
                {
                    new_reco[i - 1] = reco[i - 1];
                }
                if(rank == i)
                {
                   // new_reco[i - 1][0] =;
                    new_reco[i - 1][1] = stage1.Time_get().ToString();
                    new_reco[i - 1][2] = stage2.Time_get().ToString();
                    new_reco[i - 1][3] = totaltime.Time_get().ToString();

                    new_reco[i] = reco[i - 1];
                }
                if(rank < i)
                {
                    new_reco[i] = reco[i - 1];
                }
            }
            string str_write = "";
            int no;
            if (datenum == 5) { no = 4; } else { no = datenum; }
            for (int i = 0; i <= no; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    str_write += new_reco[i][j];
                    str_write += ",";
                }
                str_write += ",,";
            }

            FileStream file = new FileStream("Record.cvs", FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write(str_write);
        }
	}
}
