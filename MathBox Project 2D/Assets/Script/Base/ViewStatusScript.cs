using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewStatusScript : MonoBehaviour
{
    [SerializeField]
    TileControlScript TC;
    public List<TileAreaScript> tileAreaList;


    // Start is called before the first frame update
    void Start()
    {
        TC = GetComponent<TileControlScript>();
        for (int i = 0; i < tileAreaList.Count; i++)
        {
            tileAreaList[i].gameObject.SetActive(false);

        }

        switch (TC.GauType)
        {
            case 0:
                SetArea("A1");
                SetArea("A2");
                SetArea("B1");
                SetArea("B2");
                SetArea("E1");
                SetArea("E2");
                break;
            case 1:
                SetArea("A1");
                SetArea("A2");
                SetArea("B1");
                SetArea("B2");
                SetArea("E2");
                break;
            case 2:
                SetArea("A1");
                SetArea("A2");
                SetArea("E1");
                break;
            case 3:
                SetArea("A1");
                SetArea("A2");
                SetArea("E1");
                break;

        }
    }

    void SetArea(string ID)
    {
        for (int i = 0; i < tileAreaList.Count; i++)
        {
            if (tileAreaList[i].areaID == ID)
            {
                tileAreaList[i].gameObject.SetActive(true);
            }
        }
    }

}
