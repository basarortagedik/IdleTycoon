using UnityEngine;
using TMPro;

public class ShopUI : MonoBehaviour
{
    public TextMeshProUGUI buttonLabel;

    public double cost = 10;
    public double incomeGain = 1;

    public void BuyIncome()
    {
        if (GameManager.Instance == null) return;

        if (GameManager.Instance.TrySpend(cost))
        {
            GameManager.Instance.AddIncome(incomeGain);
            cost *= 1.25; // fiyat her satın almada artsın
            Refresh();
        }
        else
        {
            // paran yetmiyorsa sadece yazıyı güncelle (istersen burada uyarı verirsin)
            Refresh();
        }
    }

    void Start()
    {
        Refresh();
    }

    void Refresh()
    {
        if (GameManager.Instance == null) return;
        buttonLabel.text = $"Buy +{incomeGain:0} income (Cost: {cost:0})";
    }
}