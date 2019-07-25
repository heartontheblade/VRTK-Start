using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpacityChanger : MonoBehaviour
{
    public Material target;
    public void UpdateOpacity(float alphaValue)
    {
        Color color = target.color;
        color.a = alphaValue;
        target.color = color;
        print(alphaValue);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
