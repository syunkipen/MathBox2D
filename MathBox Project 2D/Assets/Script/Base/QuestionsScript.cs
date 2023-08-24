using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Linq;


public class QuestionsScript : MonoBehaviour
{
    [SerializeField]
    TileControlScript TC;
    [SerializeField]
    TileCharger TCH;
    [SerializeField]
    ViewStatusScript VS;
    [SerializeField]
    FormulaStorageScript FS;
    [Header("タイル出現位置＿A")]
    public GameObject pos_A;
    [Header("タイル出現位置＿B")]
    public GameObject pos_B;
    [Header("数字の表示からフェードインまでの間隔(1000で一秒)基準1000")]
    public int startFadeInTime = 1000;
    [Header("フェードインにかける時間(秒)基準0.2f")]
    public float fadeInTime = 0.2f;
    [Header("フェードインの間隔(1000で一秒)基準100")]
    public int fadeInDelayTime_A = 100; //一気に入れたい場合は0を入力
    [Header("フェードインの間隔＿各マス(1000で一秒)基準500")]
    public int fadeInDelayTime_B = 500; //一気に入れたい場合は0を入力
    [SerializeField]
    AudioClip sound1;
    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    List<GameObject> goList = new List<GameObject>();
    [SerializeField]
    List<Vector3> posList = new List<Vector3>();
    void Start()
    {
        TC = GetComponent<TileControlScript>();
        TCH = GetComponent<TileCharger>();
        VS = GetComponent<ViewStatusScript>();
        FS = GetComponent<FormulaStorageScript>();
    }

    /// <summary>
    /// 問題出題
    /// </summary>
    /// <param name="QID">出題する問題の番号</param>
    public void StartQuestion(int QID)
    {
        for (int i = 0; i < goList.Count; i++)
        {
            Destroy(goList[i].gameObject);
        }
        goList.Clear();
        posList.Clear();

        switch (TC.GauType)
        {
            case 0:
                //される数
                if ((int)FS.formulaStorageList[QID].x >= 10)
                {
                    int value_X10 = (int)FS.formulaStorageList[QID].x / 10;
                    int value_X1 = (int)FS.formulaStorageList[QID].x % 10;
                    SetQuestion("B2", value_X10);
                    SetQuestion("B1", value_X1);
                }
                else
                {
                    int value_X1 = (int)FS.formulaStorageList[QID].x;
                    SetQuestion("B2", 0);
                    SetQuestion("B1", value_X1);
                }
                //する数
                if ((int)FS.formulaStorageList[QID].y >= 10)
                {
                    int value_Y10 = (int)FS.formulaStorageList[QID].y / 10;
                    int value_Y1 = (int)FS.formulaStorageList[QID].y % 10;
                    SetQuestion("A2", value_Y10);
                    SetQuestion("A1", value_Y1);
                }
                else
                {
                    int value_Y1 = (int)FS.formulaStorageList[QID].y;
                    SetQuestion("A2", 0);
                    SetQuestion("A1", value_Y1);
                }
                break;

            case 1:
                //される数
                if ((int)FS.formulaStorageList[QID].x >= 10)
                {
                    int value_X10 = (int)FS.formulaStorageList[QID].x / 10;
                    int value_X1 = (int)FS.formulaStorageList[QID].x % 10;
                    SetQuestion("B2", value_X10);
                    SetQuestion("B1", value_X1);
                }
                else
                {
                    int value_X1 = (int)FS.formulaStorageList[QID].x;
                    SetQuestion("B2", 0);
                    SetQuestion("B1", value_X1);
                }
                //する数
                if ((int)FS.formulaStorageList[QID].y >= 10)
                {
                    int value_Y10 = (int)FS.formulaStorageList[QID].y / 10;
                    int value_Y1 = (int)FS.formulaStorageList[QID].y % 10;
                    SetValueOnly("A2", value_Y10);
                    SetValueOnly("A1", value_Y1);
                }
                else
                {
                    int value_Y1 = (int)FS.formulaStorageList[QID].y;
                    SetValueOnly("A2", 0);
                    SetValueOnly("A1", value_Y1);
                }
                break;
        }
    }

    /// <summary>
    /// 数生成
    /// </summary>
    /// <param name="ID">追加先のエリア</param>
    /// <param name="Place">追加する数</param>
    void SetValueOnly(string ID, int Place)
    {
        for (int l = 0; l < VS.tileAreaList.Count; l++)
        {
            if (VS.tileAreaList[l].areaID == ID)
            {
                if (VS.tileAreaList[l].areaType == 1)
                {
                    VS.tileAreaList[l].textMesh.text = Place.ToString();
                }
                else if (VS.tileAreaList[l].areaType == 10)
                {
                    if (Place == 0)
                    {
                        VS.tileAreaList[l].textMesh.gameObject.SetActive(false);
                        return;
                    }
                    else
                    {
                        VS.tileAreaList[l].textMesh.gameObject.SetActive(true);
                    }
                    VS.tileAreaList[l].textMesh.text = Place.ToString();
                }
            }
        }
    }
    /// <summary>
    /// タイル生成
    /// </summary>
    /// <param name="ID">追加先のエリア</param>
    /// <param name="Place">追加するタイル数</param>
    void SetQuestion(string ID, int Place)
    {
        bool On5 = false;
        for (int l = 0; l < VS.tileAreaList.Count; l++)
        {
            if (VS.tileAreaList[l].areaID == ID)
            {
                if (VS.tileAreaList[l].areaType == 1)
                {
                    VS.tileAreaList[l].textMesh.gameObject.SetActive(true);
                    VS.tileAreaList[l].textMesh.text = Place.ToString();

                    if (Place >= 5)
                    {
                        Vector3 pos = VS.tileAreaList[l].stoList1[VS.tileAreaList[l].pos5].transform.position;
                        posList.Add(pos);
                        GameObject go = Instantiate(TCH.activeTile5, pos_A.transform.position, Quaternion.identity);
                        goList.Add(go);

                        Place -= 5;
                        On5 = true;
                    }

                    if (On5)
                    {
                        for (int i = 0; i < Place; i++)
                        {
                            Vector3 pos = VS.tileAreaList[l].stoList1[i + 5].transform.position;
                            posList.Add(pos);
                            GameObject go = Instantiate(TCH.activeTile1, pos_A.transform.position, Quaternion.identity);
                            goList.Add(go);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Place; i++)
                        {
                            Vector3 pos = VS.tileAreaList[l].stoList1[i].transform.position;
                            posList.Add(pos);
                            GameObject go = Instantiate(TCH.activeTile1, pos_A.transform.position, Quaternion.identity);
                            goList.Add(go);
                        }
                    }

                }
                else if (VS.tileAreaList[l].areaType == 10)
                {
                    if (Place == 0)
                    {
                        VS.tileAreaList[l].textMesh.gameObject.SetActive(false);
                        return;
                    }
                    else
                    {
                        VS.tileAreaList[l].textMesh.gameObject.SetActive(true);
                    }
                    VS.tileAreaList[l].textMesh.text = Place.ToString();

                    if (Place >= 5)
                    {
                        Vector3 pos = VS.tileAreaList[l].stoList10[VS.tileAreaList[l].pos50].transform.position;
                        posList.Add(pos);
                        GameObject go = Instantiate(TCH.activeTile50, pos_A.transform.position, Quaternion.identity);
                        goList.Add(go);

                        Place -= 5;
                        On5 = true;
                    }
                    if (On5)
                    {
                        for (int i = 0; i < Place; i++)
                        {
                            Vector3 pos = VS.tileAreaList[l].stoList10[i + 5].transform.position;
                            posList.Add(pos);
                            GameObject go = Instantiate(TCH.activeTile10, pos_A.transform.position, Quaternion.identity);
                            goList.Add(go);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Place; i++)
                        {
                            Vector3 pos = VS.tileAreaList[l].stoList10[i].transform.position;
                            posList.Add(pos);
                            GameObject go = Instantiate(TCH.activeTile10, pos_A.transform.position, Quaternion.identity);
                            goList.Add(go);
                        }
                    }

                }
            }
        }
    }
    /// <summary>
    /// フェードイン処理
    /// </summary>
    public async void FadeInQuestion()
    {
        await Task.Delay(startFadeInTime);

        for (int i = 0; i < goList.Count; i++)
        {
            audioSource.PlayOneShot(sound1);
            iTween.MoveTo(goList[i].gameObject, posList[i], fadeInTime);
            await Task.Delay(fadeInDelayTime_A);

            //桁ごとに間隔を開ける
            if (goList[i] != goList.Last())
            {
                if (goList[i].tag != goList[i + 1].tag)
                {
                    await Task.Delay(fadeInDelayTime_B);

                }
            }
        }
        await Task.Delay(2000);

        //ナビ
        //TC.Navigation();
        //TC.SortAll();
    }

}