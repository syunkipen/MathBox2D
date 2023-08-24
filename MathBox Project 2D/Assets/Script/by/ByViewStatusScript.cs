using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByViewStatusScript : MonoBehaviour
{
    [Header("タイルエリア")]
    public List<TileAreaScript> tileAreaList;
    
    /// <summary>
    /// タイルエリアの起動
    /// </summary>
    /// <param name="Dummy">起動する数</param>
    public void SetTileArea(int Dummy)
    {
        foreach(TileAreaScript num in tileAreaList)
        {
            num.gameObject.SetActive(false);
        }

      for(int i = 0; i < Dummy; i++)
        {
            tileAreaList[i].gameObject.SetActive(true);
        }
    }
}
