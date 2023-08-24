using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveArea : MonoBehaviour
{
    //����G���A���̃^�C��
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
    /// ���X�g����obj���f�X�g���C
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