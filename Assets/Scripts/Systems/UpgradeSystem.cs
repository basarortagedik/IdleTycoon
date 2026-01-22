using UnityEngine;

public class UpgradeSystem : MonoBehaviour
{
    [Header("Upgrade")]
    public double baseCost = 10;
    public double costMultiplier = 1.5;
    public double incomeIncrease = 1;

    public int level = 0;
    public double CurrentCost => baseCost * System.Math.Pow(costMultiplier, level);

    public bool TryBuyUpgrade()
    {
        if (GameManager.Instance == null) return false;

        double cost = CurrentCost;
        if (!GameManager.Instance.TrySpend(cost)) return false;

        level++;
        GameManager.Instance.AddIncome(incomeIncrease);
        return true;
    }
}
