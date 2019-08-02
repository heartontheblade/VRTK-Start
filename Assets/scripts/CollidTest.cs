using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollidTest : MonoBehaviour
{
    public int collisionTimes = 0;
    public TestControl testControl;
    public TextMesh tmesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision hit)
    {
        print(hit.transform.tag);
        if (hit.transform.tag == "Tester")
        {
            testControl.collisionTime++;
            tmesh.text = "撞击护栏" + testControl.collisionTime + "次";
        }
        else if (hit.transform.tag == "GameController")
        {
            testControl.EndRace();
        }
    }
}
