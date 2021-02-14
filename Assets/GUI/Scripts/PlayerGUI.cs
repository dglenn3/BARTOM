using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGUI : MonoBehaviour
{
    public Button backButton;
    public Button forwardButton;
    public GameObject inventoryPanel;
    public GameObject inventoryPanelInstance;

    private void OnEnable()
    {
        Subscribe();
    }

    private void OnDestroy()
    {
        Unsubscribe();
    }

    void Start()
    {
        inventoryPanelInstance = Instantiate(inventoryPanel, this.transform.GetChild(0));
        backButton.gameObject.SetActive(false);
        forwardButton.gameObject.SetActive(false);
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
        int panels = transform.GetChild(0).childCount;
        Item item = GameManager.instance.GetItemByID(itemID);
        int childCount = inventoryPanel.transform.childCount;
        int positionInPanel = position;
        if (panels > 1)
        {
            positionInPanel = position - (childCount * (panels - 1));
        }
        if (childCount * panels <= position)
        {
            GameObject newPanel = Instantiate(inventoryPanel, this.transform.GetChild(0));
            ChangeInventoryPanel(true);
            positionInPanel = position - (childCount * (transform.GetChild(0).childCount - 1));
        }

        Image itemSlotImage = inventoryPanelInstance.transform.GetChild(positionInPanel).GetComponentInChildren<Image>();
        if (item != null && itemSlotImage != null)
        {
            itemSlotImage.sprite = item.itemIcon;
        }
    }

    public void ChangeInventoryPanel(bool nextPanel)
    {
        int currentPanelIndex = inventoryPanelInstance.gameObject.transform.GetSiblingIndex();

        if(nextPanel && currentPanelIndex < transform.GetChild(0).childCount - 1)
        {
            inventoryPanelInstance.SetActive(false);
            inventoryPanelInstance = transform.GetChild(0).GetChild(currentPanelIndex + 1).gameObject;
            backButton.gameObject.SetActive(true);
            if(currentPanelIndex + 1 >= transform.GetChild(0).childCount - 1)
            {
                forwardButton.gameObject.SetActive(false);
            }
        }
        if (!nextPanel && currentPanelIndex > 0)
        {
            inventoryPanelInstance.SetActive(false);
            inventoryPanelInstance = transform.GetChild(0).GetChild(currentPanelIndex - 1).gameObject;
            forwardButton.gameObject.SetActive(true);
            if(currentPanelIndex - 1 == 0)
            {
                backButton.gameObject.SetActive(false);
            }
        }
        inventoryPanelInstance.gameObject.SetActive(true);
    }

    private void OnToggleInventoryEvent()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
