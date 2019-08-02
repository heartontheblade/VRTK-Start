using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public int rank=0;
    public RaceControl raceControl;

    void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.root.gameObject.tag == "AI")
        {
            Fail();
        }
        else if (other.transform.root.gameObject.tag == "Player")
        {
            Success();
        }
    }

    void Fail()
    {
        rank++;
        print("Fail");
    }

    void Success()
    {
        rank++;
        print("Success");
        raceControl.EndRace(rank);
    }
}
