using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManage : MonoBehaviour
{
    Texture2D cursor;

    void Start()
    {
        cursor = Resources.Load<Texture2D>("../UI/cursor");
    }

    public void OnMouseOver()
    {
        Cursor.SetCursor(cursor, new Vector2(cursor.width / 3, 0), CursorMode.Auto);
    }
}
