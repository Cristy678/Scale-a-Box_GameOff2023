using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseXD : MonoBehaviour
{
    public Button button;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Box"))
        {
            Destroy(collision.gameObject);
            button.gameObject.SetActive(true);
        }
    }
}
