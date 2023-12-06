using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCursorOnTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UnlockCursor();
        }
    }

    void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}