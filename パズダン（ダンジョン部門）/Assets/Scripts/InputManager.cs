using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public string inputValue;
    InputField inputField;


    /// <summary>
    /// Startメソッド
    /// InputFieldコンポーネントの取得および初期化メソッドの実行
    /// </summary>
    void Start()
    {

        inputField = GetComponent<InputField>();
        StartCoroutine("InitInputField");
        
    }



    /// <summary>
    /// Log出力用メソッド
    /// 入力値を取得してLogに出力し、初期化
    /// </summary>


    public void InputLogger()
    {

        inputValue = inputField.text;

        //Debug.Log(inputValue);

        InitInputField();
    }



    /// <summary>
    /// InputFieldの初期化用メソッド
    /// 入力値をリセットして、フィールドにフォーカスする
    /// </summary>


    IEnumerator InitInputField()
    {

        // 値をリセット
        inputField.text = "";
        yield return new WaitForSeconds(1.0f);
        // フォーカス
        inputField.ActivateInputField();
    }

}
