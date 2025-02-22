using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DebugConsole : MonoBehaviour
{
    public TextMeshProUGUI logText; 
    public ScrollRect scrollRect;  

    void OnEnable()
    { 
        Application.logMessageReceived += HandleLog;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    void HandleLog(string logString, string stackTrace, LogType type)
    {
        string formattedLog = "";

        switch (type)
        {
            case LogType.Error:
                formattedLog = $"<color=red>[ERROR]</color> {logString}";
                break;
            case LogType.Warning:
                formattedLog = $"<color=yellow>[WARNING]</color> {logString}";
                break;
            case LogType.Log:
                formattedLog = $"<color=green>[LOG]</color> {logString}";
                break;
            default:
                formattedLog = logString;
                break;
        }

        logText.text += formattedLog + "\n";

        Canvas.ForceUpdateCanvases();
        ScrollToBottom();
    }


    void ScrollToBottom()
    {
        Canvas.ForceUpdateCanvases(); 
        scrollRect.verticalNormalizedPosition = 0f; 
    }

}
