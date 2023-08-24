using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using TMPro;

public class ByControlUiScript : MonoBehaviour
{
    [SerializeField] ByTileControlScript b_TC;
    [SerializeField, Header("�Z�L��")]GameObject _maru;
    [SerializeField, Header("�~�L��")]GameObject _batu;
    [Header("�i�s�x")]public DegreesBar _degreesBar;
    [Header("�i�s�x")]public Text _degreesText;
    [SerializeField]public List<GameObject> _tileIconList;
    [SerializeField]public List<GameObject> _buttonList;
    [Header("�񓚗��Q��̈�")] public Dropdown _drop_A;
    [Header("�񓚗��Q�\�̈�")]public Dropdown _drop_B;
    [Header("�N���A�\��")] public GameObject _clearUi;

    [SerializeField]public BarRange _slider_A;    //1������̐�
    [SerializeField]public BarRange _slider_B;    //�������̐�
    [SerializeField] public TMPro.TMP_Text _text_A;
    [SerializeField] public TMPro.TMP_Text _text_B;

    //[SerializeField]
    //List<GameObject> _navigationList;
    // Start is called before the first frame update

    void Start()
    {
        b_TC = GetComponent<ByTileControlScript>();
        _maru.SetActive(false);
        _batu.SetActive(false);
        _buttonList[0].gameObject.SetActive(true);
        _buttonList[1].gameObject.SetActive(false);
        _clearUi.SetActive(false);
    }

    public async void ClearEffect()
    {
        if (b_TC.formulaStorageLevel == 8 && b_TC.questionNumber == 8)
        {
            _maru.SetActive(true);
            await Task.Delay(1000);
            _maru.SetActive(false);
            _clearUi.SetActive(true);
        }
        else
        {
            _maru.SetActive(true);
            await Task.Delay(1000);
            _maru.SetActive(false);
        }
    }
    public async void UnClearEffect()
    {
        _batu.SetActive(true);
        await Task.Delay(1000);
        _batu.SetActive(false);
    }
}
