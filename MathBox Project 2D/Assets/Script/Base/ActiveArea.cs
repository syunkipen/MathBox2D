using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveArea : MonoBehaviour
{
    //操作エリア内のタイル
    public List<GameObject> areaActiveTileList = new List<GameObject>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        areaActiveTileList.Add(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        areaActiveTileList.Remove(collision.gameObject);
    }

    /// <summary>
    /// リスト内のobjをデストロイ
    /// </summary>
    public void AAClear()
    {
        for (int i = 0; i < areaActiveTileList.Count; i++)
        {
            Destroy(areaActiveTileList[i].gameObject);
        }
        areaActiveTileList.Clear();
    }
}