using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using VRTK;

public class TestControlTotal : MonoBehaviour
{
    public GameObject headMenu;
    //public GameObject messageLog;
    public Button startButton;
    public Button changeButton;
    public Button restartButton;
    public TestControl testControl;
    public TestControlTotal totalControl;
    public VRTK_Pointer leftPointer, rightPointer;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadScene();
        }
    }

    //重载场景
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //切换场景
    public void ChangeScene()
    {
        print(SceneManager.sceneCount);
        if (SceneManager.GetActiveScene().buildIndex != SceneManager.sceneCount)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }

    }


    //打开菜单
    public void openMenu()
    {
        PointerStatusChange();
        if (headMenu.activeSelf)
        {
            
            headMenu.SetActive(false);

        }
        else
        {
            headMenu.SetActive(true);
        }
    }

    //开始比赛
    public void StartTest()
    {
        testControl.enabled = true;

        startButton.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(true);
        PointerStatusChange();
        headMenu.SetActive(false);
   
    }
    //指针显示
    void PointerStatusChange()
    {
        leftPointer.enabled = !leftPointer.enabled;
        rightPointer.enabled = !rightPointer.enabled;
    }
}
