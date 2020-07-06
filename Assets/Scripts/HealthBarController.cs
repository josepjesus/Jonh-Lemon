using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    private Slider healthBar;
    private int currentHp = 4;
    
    Color color = new Color(0f, 255f, 0f);

    public int GetCurrentHp()
    {
        return currentHp;
    }

    void Awake()
    {
        healthBar = GetComponent<Slider>();
    }

    private void Start()
    {
        healthBar.gameObject.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = color;
    }

    void Update()
    {
        healthBar.value = currentHp;
    }

    public void changeHP(int newHp)
    {
        if (currentHp > 0)
        {
            currentHp = currentHp - newHp;
        }
        
    }
}
