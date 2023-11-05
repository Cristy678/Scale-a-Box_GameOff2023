using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScaleMechanic : MonoBehaviour
{
    public GameObject box;
    public float scale = 2f;
    Vector2 temp;

    private void Start()
    {
        temp = box.transform.localScale;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

            temp.x = scale;
            temp.y = scale;

        box.transform.localScale = temp;
    }
}
