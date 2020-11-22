using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [HideInInspector]
    public static PlayerInventory instance = null;

    public delegate void AddNewItem(int itemID, int position);
    public static event AddNewItem AddNewItemEvent;
    public delegate void ToggleInventory();
    public static event ToggleInventory ToggleInventoryEvent;

    private List<int> itemIDs = new List<int>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }

    public bool ReceiveItem(int itemID)
    {
        if (!itemIDs.Contains(itemID))
        {
            itemIDs.Add(itemID);
            AddNewItemEvent(itemID, itemIDs.Count - 1);
            return true;
        }
        return false;
    }

    public void ToggleInventoryVisibility()
    {
        ToggleInventoryEvent();
    }
}
