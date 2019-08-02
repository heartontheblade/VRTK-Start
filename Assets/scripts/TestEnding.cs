using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnding : MonoBehaviour
{
    public TestControl testControl;

    void OnTriggerEnter(Collider other)
    {

        testControl.EndRace();
    }

}
