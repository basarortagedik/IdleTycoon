using UnityEngine;

using TMPro;

public class MoneyUI : MonoBehaviour
{
    public TextMeshProUGUI moneyText;

    void Update()
    {
        if (GameManager.Instance == null) return;

        moneyText.text = $"₺ {GameManager.Instance.money:0}";
    }
}
