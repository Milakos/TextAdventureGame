using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Read")]
public class Read : Action
{
    public override void RespondToInput(GameContorller controller, string noun)
    {
        if (ReadItem(controller, controller.player.currentLocation.items, noun))
            return;
        if (ReadItem(controller, controller.player.inventory, noun))
            return;
        controller.currentText.text = "There is no " + noun;
    }

    private bool ReadItem(GameContorller contorller, List<Item> items, string noun)
    {
        foreach (Item item in items)
        {
            if(item.itemName == noun)
            {
                if(contorller.player.CanReadItem(contorller, item))
                {
                    if(item.InteractiWith(contorller, "read"))
                    {
                        return true;
                    }
                }
                contorller.currentText.text = "you have nothing on the " + noun + " that yoou can read";
                return true;
            }
        }
        return false;
    }
}
