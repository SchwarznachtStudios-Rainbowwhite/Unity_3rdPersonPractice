using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collect : MonoBehaviour
{
    public TMP_Text _TxtArrowCounter;
    public int _ArrowCount;


    public ObjectToCollect S_ObjectToCollect;
    public ObjectToCollect1 S_ObjectToCollect1;
    public ObjectToCollect2 S_ObjectToCollect2;

    public GameObject _EndScreen;

    public AudioSource _Pickup;

    // START START START START
    void Start()
    {
        
    }

    // UPDATE UPDATE UPDATE UPDATE
    void Update()
    {
        ObjectCounter();
    }


    public void ObjectCounter()
    {
        //Write on UI
        _TxtArrowCounter.text = _ArrowCount.ToString();

        if (_ArrowCount == 3)
        {
            _EndScreen.SetActive(true);

        }

    }





}
