using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlaceScript : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        FurnitureScript furniture = eventData.pointerDrag.GetComponent<FurnitureScript>();

        if (furniture)
        {
            furniture.defaultParent = transform;
        }
    }
}
