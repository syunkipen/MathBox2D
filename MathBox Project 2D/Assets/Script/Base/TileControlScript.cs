using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileControlScript : MonoBehaviour
{
    //DontDestroyOnLoad�I�u�W�F�N�g
//    [SerializeField]
//    ConvertScript CV;
    //����
    [SerializeField]
    TileSortScript TS;
    //�e��^�C���G���A�̃X�e�C�^�X�Ď����L
    [SerializeField]
    ViewStatusScript VS;
    //���̕ۊǁE�o��E�i�s�󋵁E����߂�
    [SerializeField]
    QuestionsScript QT;
    //�������킹
    [SerializeField]
    CheckScript CH;
    //UI�̐���
    [SerializeField]
    ControlUiScript CU;
    [SerializeField]
    FormulaStorageScript FS;

    
    [Header("�l�����Z�̐؂�ւ�(0�a�A1���A2�ρA3��)")]
    public int GauType = 0;
    [Header("��背�x��(+0�`4�A-0�`7�A�~0�`1�A��0�`1)")]
    public int formulaStorageLevel = 0;
    [Header("���ԍ�")]
    public int questionNumber = 0;


    void Start()
    {
        TS = GetComponent<TileSortScript>();
        VS = GetComponent<ViewStatusScript>();
        QT = GetComponent<QuestionsScript>();
        CH = GetComponent<CheckScript>();
        CU = GetComponent<ControlUiScript>();
        FS = GetComponent<FormulaStorageScript>();
        FS.SetFormulaStorage(GauType, formulaStorageLevel);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ClearAll();
        }
    }
    public void ClearPoint(string ID)
    {
        for (int i = 0; i < VS.tileAreaList.Count; i++)
        {
            if (VS.tileAreaList[i].areaID == ID)
            {
                TS.AreaClear(VS.tileAreaList[i]);
            }
        }
    }
    public void ClearAll()
    {
        for (int i = 0; i < VS.tileAreaList.Count; i++)
        {
            TS.AreaClear(VS.tileAreaList[i]);
        }
    }
    public void SortAll()
    {
        switch (GauType)
        {
            case 0:
                for (int i = 0; i < VS.tileAreaList.Count; i++)
                {
                    TS.AreaSort(VS.tileAreaList[i], VS.tileAreaList[i].areaType);
                }
                break;
            case 1:
                ClearPoint("A1");
                ClearPoint("A2");
                for (int i = 0; i < VS.tileAreaList.Count; i++)
                {
                    TS.AreaSort(VS.tileAreaList[i], VS.tileAreaList[i].areaType);
                }
                
                break;
        }
    }
    public void PurgeAll()
    {
        for (int i = 0; i < VS.tileAreaList.Count; i++)
        {
            TS.AreaPurge(VS.tileAreaList[i], VS.tileAreaList[i].areaType);
        }
    }
    public void PleaseQuestion()
    {

        CU.buttonList[0].gameObject.SetActive(false);
        CU.buttonList[1].gameObject.SetActive(true);
        ClearAll();
        QT.StartQuestion(questionNumber);
        QT.FadeInQuestion();
        CU.degreesBar.BarAction(FS.formulaStorageList.Count - 1, questionNumber + 1);
        SortAll();
    }
    public void Send()
    {
        if (FS.formulaStorageList[questionNumber + 1].x == 999)
        {
            formulaStorageLevel++;
            questionNumber = 0;
            FS.SetFormulaStorage(GauType, formulaStorageLevel);
            PleaseQuestion();
            return;
        }
        questionNumber++;
        PleaseQuestion();
    }
    public void Retum()
    {
        if (questionNumber == 0) return;
        questionNumber--;
        PleaseQuestion();
    }
    public void Check()
    {
        CH.CheckStandby(GauType, questionNumber);
    }
    public void Navigation()
    {
        CU.SetNavigation(0);
    }
}
