using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Get")]
public class Get : Action
{
    public override void RespondToInput(GameContorller controller, string noun)
    {
        foreach (Item item in controller.player.currentLocation.items)
        {
            if(item.itemEnabled && item.itemName == noun)
            {
                controller.player.inventory.Add(item);
                controller.player.currentLocation.items.Remove(item);
                controller.currentText.text = " You can take the "+ noun;
                return;
            }
        }
        controller.currentText.text = "You cant't take the "+ noun;
    }
    
}
