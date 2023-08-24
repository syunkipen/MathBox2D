using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByQuestionsScript : MonoBehaviour
{
    [SerializeField]ByControlUiScript b_CU;     //UI
    [SerializeField]ByTileCharger b_TCH;        //タイルプレハブ
    [SerializeField]FormulaStorageScript FS;    //問題
    [SerializeField] ByViewStatusScript b_VS;   //タイルエリア
    [SerializeField] List<GameObject> go = new List<GameObject>();

    public int _answer;
    void Start()
    {
        b_CU = GetComponent<ByControlUiScript>();
        b_TCH = GetComponent<ByTileCharger>();
        FS = GetComponent<FormulaStorageScript>();
        b_VS = GetComponent<ByViewStatusScript>();

    }

    /// <summary>
    /// 問題出題
    /// </summary>
    /// <param name="QID">出題する問題の番号</param>
    public void StartQuestion(int QID)
    {
        int X = (int)FS.formulaStorageList[QID].x;
        int Y = (int)FS.formulaStorageList[QID].y;
        int Z = X * Y;
        _answer = Z;
        //ゲージ
        b_CU._slider_A.SetBar(X);
        b_CU._slider_B.SetBar(Y);
        //Text表示
        b_CU._text_A.text = X.ToString();
        b_CU._text_B.text = Y.ToString();
        b_CU._degreesText.text = X.ToString();
        //タイルエリアの起動
        b_VS.SetTileArea(Y);
        //タイルアイコンの起動
        SetTileIcon(X);

        //回答欄の表示
        if(Z >= 10)
        {
            b_CU._drop_A.gameObject.SetActive(true);
            b_CU._drop_B.gameObject.SetActive(true);
        }
        else
        {
            b_CU._drop_A.gameObject.SetActive(true);
            b_CU._drop_B.gameObject.SetActive(false);
        }

        //タイルを配置
        //OnNewTile(X);
    }

    public void OnNewTile(int ID)
    {
        Vector3 pos = new Vector3(60, 400, -10);
        GameObject Dummy = Instantiate(b_TCH._tilePrefabList[ID].gameObject, pos, Quaternion.identity);
        go.Add(Dummy);
    }

    public void OnTileClear()
    {
        foreach (GameObject num in go)
        {
            Destroy(num);
        }
        go.Clear();
    }

    public void SetTileIcon(int Dummy)
    {
        foreach(GameObject num in b_CU._tileIconList)
        {
            num.gameObject.SetActive(false);
        }
        switch (Dummy)
        {
            case 1:
                b_CU._tileIconList[1].gameObject.SetActive(true);
                break;
            case 2:
                b_CU._tileIconList[2].gameObject.SetActive(true);
                break;
            case 3:
                b_CU._tileIconList[3].gameObject.SetActive(true);
                break;
            case 4:
                b_CU._tileIconList[4].gameObject.SetActive(true);
                break;
            case 5:
                b_CU._tileIconList[5].gameObject.SetActive(true);
                break;
            case 6:
                b_CU._tileIconList[1].gameObject.SetActive(true);
                b_CU._tileIconList[5].gameObject.SetActive(true);
                break;
            case 7:
                b_CU._tileIconList[2].gameObject.SetActive(true);
                b_CU._tileIconList[5].gameObject.SetActive(true);
                break;
            case 8:
                b_CU._tileIconList[3].gameObject.SetActive(true);
                b_CU._tileIconList[5].gameObject.SetActive(true);
                break;
            case 9:
                b_CU._tileIconList[4].gameObject.SetActive(true);
                b_CU._tileIconList[5].gameObject.SetActive(true);
                break;
        }
    }
}
