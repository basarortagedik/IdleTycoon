using UnityEngine;

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Economy")]
    public double money = 0;
    public double incomePerSecond = 1;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    void Update()
    {
        money += incomePerSecond * Time.deltaTime;
        Debug.Log(money);
    }

    public bool TrySpend(double amount)
    {
        if (money < amount) return false;
        money -= amount;
        return true;
    }

    public void AddIncome(double amountPerSecond)
    {
        incomePerSecond += amountPerSecond;
    }
}
