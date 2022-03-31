using System.Collections;
using System.Collections.Generic;
using Unity.AutomatedQA;
using UnityEngine;

public class UITest : MonoBehaviour
{
    public AutomatedRun automatedRun;  
    public AutomatedRun multipleAutomatedRun;
    [SerializeField]
    private bool multipleTimeTest = true;
    void Start()
    {
        if(multipleTimeTest)
        RunMultipleTimes();
        else
        RunTest();
    }

    void RunTest()
    {
        CentralAutomationController.Instance.Run(automatedRun.config);
    }    
    void RunMultipleTimes()
    {
        CentralAutomationController.Instance.Run(multipleAutomatedRun.config);
    }    
}
