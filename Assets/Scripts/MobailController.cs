using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MobailController : MonoBehaviour,IDragHandler, IPointerUpHandler, IPointerDownHandler
{ public virtual void OnPointerDown(PointerEventData ped)
    {
        print("PointerDown");
    }

    public virtual void OnPointerUp(PointerEventData ped)
    {
        print("PointerUp");
    }

    public virtual void OnDrag(PointerEventData ped)
    {
        print("OnDrag");
    }
    
}
