using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Say")]
public class Say : Action
{
    public override void RespondToInput(GameContorller controller, string noun)
    {
        if (SayToItem(controller, controller.player.currentLocation.items, noun))
        {
            return;
        }
        controller.currentText.text = "Nothing Responds";
    }

    private bool SayToItem(GameContorller controller, List<Item> items, string noun)
    {
        foreach (Item item in items)
        {
            if (item.itemEnabled)
            {
                if (controller.player.CanTalkToItem(controller, item))
                {
                    if(item.InteractiWith(controller, "say", noun))
                    {
                        return true;
                    }
                }
            }

        }
        return false;
    }
}
