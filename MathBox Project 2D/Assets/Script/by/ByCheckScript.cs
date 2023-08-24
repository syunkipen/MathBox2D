using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ByCheckScript : MonoBehaviour
{
    [SerializeField] ByTileControlScript b_TC;
    [SerializeField] ByQuestionsScript b_QT;
    [SerializeField] ByControlUiScript b_CU;
    [SerializeField] ByViewStatusScript b_VS;
    // Start is called before the first frame update
    void Start()
    {
        b_TC = GetComponent<ByTileControlScript>();
        b_QT = GetComponent<ByQuestionsScript>();
        b_CU = GetComponent<ByControlUiScript>();
        b_VS = GetComponent<ByViewStatusScript>();
    }
    public void CheckStandby()
    {
        int Answer = b_QT._answer;
        int Drop = b_CU._drop_A.value + (b_CU._drop_B.value * 10);
        int Area = 0;
        foreach (TileAreaScript num in b_VS.tileAreaList)
        {
            Area += num.areaTilePower;
        }
        
        if(Answer == Drop && Answer == Area)
        {
            CheckCLEAR();
        }
        else
        {
            CheckUnCLEAR();
        }
    }

    void CheckCLEAR()
    {
        if (b_TC.formulaStorageLevel == 8 && b_TC.questionNumber == 8)
        {
            b_CU.ClearEffect();
        }
        else
        {

            b_TC.Send();
            b_CU._drop_A.value = 0;
            b_CU._drop_B.value = 0;
            b_CU.ClearEffect();
        }
    }
    void CheckUnCLEAR()
    {
        b_CU.UnClearEffect();
    }

}
