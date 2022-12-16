using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Use")]
public class Use : Action
{
    public override void RespondToInput(GameContorller controller, string noun)
    {
        if (UseItems(controller, controller.player.currentLocation.items, noun))
            return;
        if (UseItems(controller, controller.player.inventory, noun))
            return;
        controller.currentText.text = "There is no " + noun;
    }

    private bool UseItems(GameContorller contorller, List<Item> items, string noun)
    {
        foreach (Item item in items)
        {
            if(item.itemName == noun)
            {
                if(contorller.player.CanUseItem(contorller, item))
                {
                    if(item.InteractiWith(contorller, "use"))
                    {
                        return true;
                    }
                }

                   
                contorller.currentText.text = "The " + noun + "does nothing";
                return true;
            }
        }
        return false;
    }
}
