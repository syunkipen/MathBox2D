using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByViewStatusScript : MonoBehaviour
{
    [Header("�^�C���G���A")]
    public List<TileAreaScript> tileAreaList;
    
    /// <summary>
    /// �^�C���G���A�̋N��
    /// </summary>
    /// <param name="Dummy">�N�����鐔</param>
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
