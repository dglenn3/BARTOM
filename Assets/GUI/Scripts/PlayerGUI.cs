using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGUI : MonoBehaviour
{
    public GameObject inventoryPanel;

    private void OnEnable()
    {
        Subscribe();
    }

    private void OnDestroy()
    {
        Unsubscribe();
    }

    private void Subscribe()
    {
        PlayerInventory.AddNewItemEvent += OnAddNewItemEvent;
        PlayerInventory.ToggleInventoryEvent += OnToggleInventoryEvent;
    }

    private void Unsubscribe()
    {
        PlayerInventory.AddNewItemEvent -= OnAddNewItemEvent;
        PlayerInventory.ToggleInventoryEvent -= OnToggleInventoryEvent;
    }

    private void OnAddNewItemEvent(int itemID, int position)
    {
        Item item = GameManager.instance.GetItemByID(itemID);
        Image itemSlotImage = inventoryPanel.transform.GetChild(position).GetComponentInChildren<Image>();
        if (item != null && itemSlotImage != null)
        {
            itemSlotImage.sprite = item.itemIcon;
        }
    }

    private void OnToggleInventoryEvent()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
