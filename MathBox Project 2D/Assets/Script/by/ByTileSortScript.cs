using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByTileSortScript : MonoBehaviour
{
    [SerializeField] ByTileCharger b_TCH;
    [SerializeField] ByViewStatusScript b_VS;
    [SerializeField] ByTileControlScript b_TC;
    private void Start()
    {
        b_TCH = GetComponent<ByTileCharger>();
        b_VS = GetComponent<ByViewStatusScript>();
        b_TC = GetComponent<ByTileControlScript>();
    }
    /// <summary>
    /// ƒ^ƒCƒ‹‚Ì®“Ú
    /// </summary>
    /// <param name="Dummy">®“Ú‘ÎÛ</param>
    public void AreaSort(TileAreaScript ID)
    {
        bool on5 = false;
        int atc = ID.areaTileList.Count;

        
        if (b_TC.formulaStorageLevel >= 5)
        {
            for (int i = 0; i < atc; i++)
            {
                if (ID.areaTileList[i].tag == "ActiveTile5" && !on5)
                {
                    ID.areaTileList[i].gameObject.transform.position = ID.stoList1[0].transform.position;
                    on5 = true;
                }
                else
                {
                    if (on5)
                    {
                        ID.areaTileList[i].gameObject.transform.position = ID.stoList1[5].transform.position;
                    }
                    else
                    {
                        ID.areaTileList[i].gameObject.transform.position = ID.stoList1[0].transform.position;
                    }
                }

            }
        }
        else
        {
         if(atc != 0)ID.areaTileList[0].gameObject.transform.position = ID.stoList1[0].transform.position;
        }

    }


}
