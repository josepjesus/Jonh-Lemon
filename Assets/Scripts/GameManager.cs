using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerNameText;

    public Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
        playerNameText.text = player.Nickname + "'s Health";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
