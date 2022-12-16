using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Help")]
public class Help : Action
{
    
    public override void RespondToInput(GameContorller controller, string noun)
    {
        controller.currentText.text = "Type a Verb followed by a noun(e.g. \"go north\")";
        controller.currentText.text += "/nAllowed verbs: \nGo, Examine, Get, Use, Inventory, TalkTo, Give, Say, Read, Help";
    }
}
