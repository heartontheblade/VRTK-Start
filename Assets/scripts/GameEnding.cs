using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{
    

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
        print("Fail");
    }

    void Success()
    {
        print("Success");
    }
}
