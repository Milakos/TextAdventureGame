using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Go")]
public class Go : Action
{
    public override void RespondToInput(GameContorller controller, string noun)
    {
        if(controller.player.ChangeLocation(controller,noun))
        {
            controller.DisplayLocation();
        }
        else
        {
            controller.currentText.text = "You cant't go that way";
        }
    }
}
