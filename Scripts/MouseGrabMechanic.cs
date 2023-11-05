using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MouseGrabMechanic : MonoBehaviour
{
    public AudioSource boxSound;

    bool Preesed = false;

    public void OnMouseDown()
    {
        Preesed = true;
        GetComponent<Rigidbody2D>().isKinematic = true;
        boxSound.Play();
    }
    public void OnMouseUp()
    {
        Preesed = false;
        GetComponent<Rigidbody2D>().isKinematic = false;
    }
    void Update()
    {
        if (Preesed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
    }
}
