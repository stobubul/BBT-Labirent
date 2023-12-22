using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinTextComponent;
    public int coinCount;

    public void IncreaseCoin()
    {
        coinCount++;
        coinTextComponent.text = $"Coins: {coinCount}";
    }
}
