using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostObserver : MonoBehaviour
{
    public Transform player;
    public GameEnding gameEnding;

    bool m_IsPlayerInRange;

    public HealthBarController hbc;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = true;

            Vector3 direction = player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position, direction);
            RaycastHit raycastHit;

            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == player)
                {
                    hbc.changeHP(2);
                    if (hbc.GetCurrentHp() <= 0)
                    {
                        gameEnding.CaughtPlayer();
                        TotalCoins.totalCoins = 0;
                    }
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = false;
        }
    }

    void Update()
    {
        if (m_IsPlayerInRange)
        {
            player.GetComponent<Rigidbody>().AddForce(-player.transform.forward * 0.5f, ForceMode.Impulse);
        }
    }
}
