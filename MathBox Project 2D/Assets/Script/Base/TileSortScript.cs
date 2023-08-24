using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSortScript : MonoBehaviour
{
    [SerializeField]
    TileCharger TCH;

    private void Start()
    {
        TCH = GetComponent<TileCharger>();
    }
    /// <summary>
    /// エリアのタイルを空に
    /// </summary>
    /// <param name="Dummy">対象のエリア</param>
    public void AreaClear(TileAreaScript Dummy)
    {
        //リストをクリア
        for (int i = 0; i < Dummy.areaTileList.Count; i++)
        {
            Dummy.areaTileList[i]._isDestroy = true;
        }
        
        Dummy.areaTileList.Clear();
        Dummy.areaTilePower = 0;
    }
    /// <summary>
    /// エリアのタイルを整頓。
    /// </summary>
    /// <param name="Dummy"></param>
    /// <param name="Place">担当の位</param>
    public void AreaSort(TileAreaScript Dummy, int Place)
    {
        if (Place == 1)
        {
            bool on5 = false;
            int atp = Dummy.areaTilePower;
            int atl_c = Dummy.areaTileList.Count;


            if (atp == 10)
            {
                AreaClear(Dummy);

                Vector3 pos = Dummy.stoList1[Dummy.pos10].transform.position;
                Instantiate(TCH.activeTile10, pos, Quaternion.identity);
                return;
            }
            else if (atp <= 9 && atp >= 5)
            {
                AreaClear(Dummy);

                Vector3 pos = Dummy.stoList1[Dummy.pos5].transform.position;
                Instantiate(TCH.activeTile5, pos, Quaternion.identity);
                atp = atp - 5;

                for (int i = 0; i < atp; i++)
                {
                    Vector3 pos1 = Dummy.stoList1[i + 5].transform.position;
                    Instantiate(TCH.activeTile1, pos1, Quaternion.identity);
                }
            }

            //整列
            //タイルをmyNunber順に整列
            for (int i = 0; i < Dummy.areaTileList.Count; i++)
            {
                //タイル10があるか？
                if (Dummy.areaTileList[i].tag == "ActiveTile10")
                {
                    Dummy.areaTileList[i].transform.position = Dummy.stoList1[Dummy.pos10].transform.position;
                    return;
                }
                //タイル5があるか？
                else if (Dummy.areaTileList[i].tag == "ActiveTile5")
                {
                    Dummy.areaTileList[i].transform.position = Dummy.stoList1[Dummy.pos5].transform.position;
                    i++;
                    on5 = true;
                }

                if (on5)
                {
                    Dummy.areaTileList[i].transform.position = Dummy.stoList1[i + 4].transform.position;
                }
                else
                {
                    Dummy.areaTileList[i].transform.position = Dummy.stoList1[i].transform.position;

                }
            }
        }
        else if (Place == 10)
        {
            bool on5 = false;
            int atp = Dummy.areaTilePower / 10;
            int atl_c = Dummy.areaTileList.Count;

            if (atp >= 5)
            {
                AreaClear(Dummy);

                Vector3 pos = Dummy.stoList10[Dummy.pos50].transform.position;
                Instantiate(TCH.activeTile50, pos, Quaternion.identity);
                atp = atp - 5;

                for (int i = 0; i < atp; i++)
                {
                    Vector3 pos1 = Dummy.stoList10[i + 5].transform.position;
                    Instantiate(TCH.activeTile10, pos1, Quaternion.identity);
                }
            }

            //整列
            //タイルをmyNunber順に整列
            for (int i = 0; i < Dummy.areaTileList.Count; i++)
            {
                //タイル50があるか？
                if (Dummy.areaTileList[i].tag == "ActiveTile50")
                {
                    Dummy.areaTileList[i].transform.position = Dummy.stoList10[Dummy.pos50].transform.position;
                    i++;
                    on5 = true;
                }

                if (on5)
                {
                    Dummy.areaTileList[i].transform.position = Dummy.stoList10[i].transform.position;
                }
                else
                {
                    Dummy.areaTileList[i].transform.position = Dummy.stoList10[i].transform.position;
                }
            }

        }
    }
    /// <summary>
    /// エリアのタイルを分解
    /// </summary>
    /// <param name="Dummy"></param>
    /// <param name="Place"></param>
    public void AreaPurge(TileAreaScript Dummy, int Place)
    {
        if (Place == 1)
        {
            int atp = Dummy.areaTilePower;

            AreaClear(Dummy);

            if (atp == 10)
            {
                Vector3 pos = Dummy.stoList1[Dummy.pos5].transform.position;
                Instantiate(TCH.activeTile5, pos, Quaternion.identity);
                atp = atp - 5;

                for (int i = 0; i < atp; i++)
                {
                    Vector3 pos1 = Dummy.stoList1[i + 5].transform.position;
                    Instantiate(TCH.activeTile1, pos1, Quaternion.identity);
                }
                return;
            }
            else
            {
                for (int i = 0; i < atp; i++)
                {
                    Vector3 pos = Dummy.stoList1[i].transform.position;
                    Instantiate(TCH.activeTile1, pos, Quaternion.identity);
                }
            }
        }
        else if (Place == 10)
        {
            int atp = Dummy.areaTilePower / 10;
            AreaClear(Dummy);

            for (int i = 0; i < atp; i++)
            {
                Vector3 pos = Dummy.stoList10[i].transform.position;
                Instantiate(TCH.activeTile10, pos, Quaternion.identity);
            }
        }
    }

}
