using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToCollect1 : MonoBehaviour
{
    public Collect S_Collect;
    public GameObject Arrow1;

    // START START START START
    void Start()
    {

    }

    // UPDATE UPDATE UPDATE UPDATE
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            S_Collect._ArrowCount = S_Collect._ArrowCount + 1 ;

            S_Collect._Pickup.Play();

            Arrow1.SetActive(false);
        }


    }
}
