using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogDisplay : MonoBehaviour
{
    public TMP_Text logText;

    private string logMessages = "Log Display \n"; 

    private void OnEnable()
    {
        Application.logMessageReceived += Log;
    }

    private void OnDisable()
    {
        Application.logMessageReceived -= Log;
    }

    void Log(string logString, string stackTrace, LogType type)
    {
        logMessages += logString + "\n";
        logText.text = logMessages;
    }
}
