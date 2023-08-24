using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownNumberScript : MonoBehaviour
{
    //ドロップダウンオブジェクト
    public Dropdown ddtmp;

    public List<string> optionlist = new List<string>();
    public string selectedvalue = null;

    //選択された値
    [Header("選択中の値")]
    public int valueNumber = 0;
    [Header("位タイプ")]
    public int Type = 0;

    void Start()
    {
        switch (Type)
        {
            case 1:
                //選択肢を追加
                optionlist.Add("0");
                optionlist.Add("1");
                optionlist.Add("2");
                optionlist.Add("3");
                optionlist.Add("4");
                optionlist.Add("5");
                optionlist.Add("6");
                optionlist.Add("7");
                optionlist.Add("8");
                optionlist.Add("9");
                break;


            case 10:
                optionlist.Add("0");
                optionlist.Add("1");
                break;
        }


        //DropdownコンポーネントのOptionsという項目のリスト
        //を編集するためにDropdownコンポーネントを取得
        ddtmp = GetComponent<Dropdown>();

        //Optionsをクリア
        ddtmp.ClearOptions();

        //リストを追加
        ddtmp.AddOptions(optionlist);
    }

    public void Update()
    {
        valueNumber = ddtmp.value;

    }

    public void AddTile()
    {
    }

    public void GetType()
    {
        //DropDownコンポーネントのoptionsから選択されてているvalueをindexで指定し、
        //選択されている文字を樹徳
        selectedvalue = ddtmp.options[ddtmp.value].text;
    }
}