using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Unit : MonoBehaviour, IDragHandler {
    private BoxCollider2D box;
	// Use this for initialization
	public void Start () {
        box = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	public void Update () {
     //   box.transform.position = box.transform.position + Vector3.right;
	}
    

    public void OnDrag(BaseEventData eventData)
    {
        Debug.Log("drag");
        //transform.position += eventData.delta
    }

    public void OnDrag(PointerEventData eventData)
    {
        var d = new Vector3(eventData.delta.x, eventData.delta.y, 0f);
        transform.localPosition += d;
    }
}
