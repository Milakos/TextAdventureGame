using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameContorller : MonoBehaviour
{
    
    public Player player;
    public TMP_InputField textEntryField;
    public TMP_Text logText;
    public TMP_Text currentText;

    public Action[] actions;
    
    [TextArea]
    public string introText;

    // Start is called before the first frame update
    void Start()
    {
        logText.text = introText;
        DisplayLocation();
        textEntryField.ActivateInputField();
    }

    public void DisplayLocation(bool additive = false)
    {
        string description = player.currentLocation.description+ "\n";
        description += player.currentLocation.GetConnections();
        description += player.currentLocation.GetItemsText();
        if(additive)
            currentText.text = currentText.text + "/n" + description;
        else
            currentText.text = description;
    }

    public void TextEntered()
    {
        Debug.Log("textEntered");
        LogCurentText();
        ProcesInput(textEntryField.text);
        textEntryField.text = "";
        textEntryField.ActivateInputField();
    }

    void LogCurentText()
    {
        logText.text += "\n";
        logText.text += currentText.text;

        logText.text += "\n\n";
        logText.text += "<color=#aaccaaff>"+ textEntryField.text +"</color>";
    }

    void ProcesInput(string input)
    {
        input = input.ToLower();

        char[] delimiter = {' '};
        string[] seperatedWords = input.Split(delimiter);
        
        foreach (Action action in actions)
        {
            if (action.keyword.ToLower() == seperatedWords[0])
            {
                if(seperatedWords.Length > 1)
                {
                    action.RespondToInput(this, seperatedWords[1]);
                }
                else
                {
                    action.RespondToInput(this, "");
                }
                return;
            }
        }

        currentText.text = "Nothing happens! (having trouble? type Help)";
    }
}
