using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Update()
    {
        /*if (Input.touchCount > 0)
        {
           ChangePositionByTouch();
        }*/
        
        ChangePositionByMouse();
    }

    private void ChangePositionByTouch()
    {
        Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
        touchPosition.z = transform.position.z;
        transform.position = touchPosition;
    }

    private void ChangePositionByMouse()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z);
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}

