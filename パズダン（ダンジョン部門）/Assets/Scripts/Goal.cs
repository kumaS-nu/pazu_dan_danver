using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class Goal : MonoBehaviour {
    public string nextscene;
    public Timer time;
    public string filename;
    // Use this for initialization
    void OnTriggerEnter(Collider hit)
    {
        if (hit.CompareTag("Player"))
        {
            FileStream BinaryFile = new FileStream(filename + ".dat", FileMode.Create, FileAccess.Write);   //クリアタイム書き込み
            BinaryWriter Writer = new BinaryWriter(BinaryFile);
            Writer.Write(time.spend_time / 100);
            SceneManager.LoadScene(nextscene);     // 次のステージへ
        }
    }
    
}
