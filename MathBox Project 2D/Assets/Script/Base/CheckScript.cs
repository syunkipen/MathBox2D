using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScript : MonoBehaviour
{
    [SerializeField]
    TileControlScript TC;
    [SerializeField]
    ViewStatusScript VS;
    [SerializeField]
    FormulaStorageScript FS;
    [SerializeField]
    ControlUiScript CU;

    // Start is called before the first frame update
    void Start()
    {
        TC = GetComponent<TileControlScript>();
        VS = GetComponent<ViewStatusScript>();
        FS = GetComponent<FormulaStorageScript>();
        CU = GetComponent<ControlUiScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckStandby(int GT, int QID)
    {
        switch (GT)
        {
            case 0:
                //–â‘è‚Ì“š
                int Dummy_10 = ((int)FS.formulaStorageList[QID].x + (int)FS.formulaStorageList[QID].y) / 10;
                //‰ñ“š‚Ì“š
                int Dummy_1 = ((int)FS.formulaStorageList[QID].x + (int)FS.formulaStorageList[QID].y) % 10;

                if (Dummy_10 == CU.dd_10.value && Dummy_1 == CU.dd_1.value)
                {
                    CheckCLEAR();
                }
                else
                {
                    CheckUnCLEAR();
                }
                break;
            case 1:
                //–â‘è‚Ì“š
                Dummy_10 = ((int)FS.formulaStorageList[QID].x - (int)FS.formulaStorageList[QID].y) / 10;
                //‰ñ“š‚Ì“š
                Dummy_1 = ((int)FS.formulaStorageList[QID].x - (int)FS.formulaStorageList[QID].y) % 10;

                if (Dummy_10 == CU.dd_10.value && Dummy_1 == CU.dd_1.value)
                {
                    CheckCLEAR();
                }
                else
                {
                    CheckUnCLEAR();
                }
                break;

        }
    }

    void CheckCLEAR()
    {
        TC.Send();
        CU.dd_10.value = 0;
        CU.dd_1.value = 0;
        CU.ClearEffect();
    }

    void CheckUnCLEAR()
    {
        CU.UnClearEffect();
    }
}