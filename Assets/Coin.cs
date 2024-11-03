using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private CoinManager coinManager; // Referência ao CoinManager

    void Start()
    {
        // Encontra o CoinManager na cena
        coinManager = FindFirstObjectByType<CoinManager>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisão detectada");

        if (other.CompareTag("Player"))
        {
            coinManager.AddCoin();
            Destroy(gameObject);
        }  
    }
}
