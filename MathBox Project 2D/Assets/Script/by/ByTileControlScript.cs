using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByTileControlScript : MonoBehaviour
{
    //整頓
    [SerializeField]
    ByTileSortScript b_TS;
    //各種エリアのステイタスを監視共有
    [SerializeField]
    ByViewStatusScript b_VS;
    //問題の出題・進行・送り戻し
    [SerializeField]
    ByQuestionsScript b_QT;
    //答え合わせ
    [SerializeField]
    ByCheckScript b_CH;
    //UIの制御
    [SerializeField]
    ByControlUiScript b_CU;
    //問題
    [SerializeField]
    FormulaStorageScript FS;

    [Header("四測演算の切り替え(0和、1差、2積、3商)")]
    public int GauType = 2;
    [Header("問題レベル(+0～4、-0～7、×0～8、÷0～1)")]
    public int formulaStorageLevel = 0;
    [Header("問題番号")]
    public int questionNumber = 0;

    [SerializeField]
    private float _stepTimeCount;
    [Header("自動ナビ開始までの時間(60.0fで1秒)")]
    private float _stepTime = 30.0f;


    void Start()
    {
        b_TS = GetComponent<ByTileSortScript>();
        b_VS = GetComponent<ByViewStatusScript>();
        b_QT = GetComponent<ByQuestionsScript>();
        b_CU = GetComponent<ByControlUiScript>();
        b_CH = GetComponent<ByCheckScript>();
        FS = GetComponent<FormulaStorageScript>();
        FS.SetFormulaStorage(GauType, formulaStorageLevel);
        _stepTimeCount = 0.0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PleaseQuestion();   
        }

        _stepTimeCount += Time.deltaTime;
        //一定時間操作がない
        if (_stepTimeCount > _stepTime)
        {
            //ナビ開始
            PlayNavigation();
        }
    }
    private void OnMouseDown()
    {
        _stepTimeCount = 0.0f;
    }
    public void PlayNavigation()
    {
        //Debug.Log("操作なし");
    }

    public void ClearAll()
    {
        b_QT.OnTileClear();
    }
    public void SortAll()
    {
        foreach(TileAreaScript num in b_VS.tileAreaList)
        {
            b_TS.AreaSort(num);
        }
    }
    public void PleaseQuestion()
    {
        b_CU._buttonList[0].gameObject.SetActive(false);
        b_CU._buttonList[1].gameObject.SetActive(true);
        ClearAll();
        b_QT.StartQuestion(questionNumber);
        b_CU._degreesBar.BarAction(FS.formulaStorageList.Count - 1, questionNumber + 1);

    }

    public void OnPleaseTile(int Dummy)
    {
        b_QT.OnNewTile(Dummy);
    }

    public void Send()
    {
        if(formulaStorageLevel == 8 && questionNumber == 8) return;

        if (FS.formulaStorageList[questionNumber + 1].x == 999)
        {
            formulaStorageLevel++;
            questionNumber = 0;
            FS.SetFormulaStorage(GauType, formulaStorageLevel);
        }
        else
        {
            questionNumber++;
        }
        PleaseQuestion();
    }
    public void Retum()
    {
        if (formulaStorageLevel == 0 && questionNumber == 0) return;

        if (questionNumber == 0) {
            formulaStorageLevel--;
            questionNumber = FS.formulaStorageList.Count - 2;
            FS.SetFormulaStorage(GauType, formulaStorageLevel);
        }
        else
        {
            questionNumber--;
        }
        PleaseQuestion();
    }

    public void Check()
    {
        b_CH.CheckStandby();
    }
}
