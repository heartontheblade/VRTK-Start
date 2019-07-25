using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceControl : MonoBehaviour
{
    public int TotalTime = 4;//总时间

    public Text TimeText;//在UI里显示时间
    

    private SimpleAI[] AIs;
    public GameObject player;

    

    private int second;//秒

    void Start()
    {

        AIs = GameObject.FindObjectsOfType<SimpleAI>();
        

        StartCoroutine(startTime());   //运行一开始就进行协程

    }

    public IEnumerator startTime()
    {

        while (TotalTime > 0)
        {

            //Debug.Log(TotalTime);//打印出每一秒剩余的时间

            yield return new WaitForSeconds(1);//由于开始倒计时，需要经过一秒才开始减去1秒，
                                               //所以要先用yield return new WaitForSeconds(1);然后再进行TotalTime--;运算

            TotalTime--;

            TimeText.text =TotalTime.ToString();

            if (TotalTime <= 0)
            {                //如果倒计时剩余总时间为0时，就开始比赛
                TimeText.text = "Start!!!";
                StartRace();
                yield return new WaitForSeconds(1);
                TimeText.text = "";

            }

            

            //string length = mumite.ToString();
            //if (second >= 10)
            //{

            //    TimeText.text = "0" + mumite + ":" + second;
            //}     //如果秒大于10的时候，就输出格式为 00：00

            //else
            //    TimeText.text = "0" + mumite + ":0" + second;      //如果秒小于10的时候，就输出格式为 00：00

        }


    }

    void StartRace()
    {
        for(int i = 0; i < AIs.Length; i++)
        {
            AIs[i].Activate();
        }
        //player.Activate();
        player.GetComponent<SimpleCarController>().enabled = true;

    }
}
