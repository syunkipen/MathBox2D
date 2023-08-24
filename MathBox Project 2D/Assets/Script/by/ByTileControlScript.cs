using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByTileControlScript : MonoBehaviour
{
    //����
    [SerializeField]
    ByTileSortScript b_TS;
    //�e��G���A�̃X�e�C�^�X���Ď����L
    [SerializeField]
    ByViewStatusScript b_VS;
    //���̏o��E�i�s�E����߂�
    [SerializeField]
    ByQuestionsScript b_QT;
    //�������킹
    [SerializeField]
    ByCheckScript b_CH;
    //UI�̐���
    [SerializeField]
    ByControlUiScript b_CU;
    //���
    [SerializeField]
    FormulaStorageScript FS;

    [Header("�l�����Z�̐؂�ւ�(0�a�A1���A2�ρA3��)")]
    public int GauType = 2;
    [Header("��背�x��(+0�`4�A-0�`7�A�~0�`8�A��0�`1)")]
    public int formulaStorageLevel = 0;
    [Header("���ԍ�")]
    public int questionNumber = 0;

    [SerializeField]
    private float _stepTimeCount;
    [Header("�����i�r�J�n�܂ł̎���(60.0f��1�b)")]
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
        //��莞�ԑ��삪�Ȃ�
        if (_stepTimeCount > _stepTime)
        {
            //�i�r�J�n
            PlayNavigation();
        }
    }
    private void OnMouseDown()
    {
        _stepTimeCount = 0.0f;
    }
    public void PlayNavigation()
    {
        //Debug.Log("����Ȃ�");
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
