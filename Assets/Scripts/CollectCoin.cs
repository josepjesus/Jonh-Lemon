using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public Transform player;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform == player)
        {
            Destroy(gameObject);
            TotalCoins.totalCoins++;
            Debug.Log(TotalCoins.totalCoins);
        }
    }

    void Update()
    {
        transform.Rotate((Time.deltaTime * 30.0f)%360, 0, 0);
    }
}
