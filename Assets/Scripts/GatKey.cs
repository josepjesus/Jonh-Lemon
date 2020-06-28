using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatKey : MonoBehaviour
{
    public Image im;
    public Sprite keySprite;
    private void OnTriggerEnter(Collider other)
    {
        im.color = new Color(im.color.r, im.color.g, im.color.b, 1f);
        im.sprite = keySprite;
        Destroy(gameObject);
    }
}
