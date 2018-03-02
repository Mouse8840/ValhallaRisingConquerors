using UnityEngine;

public class BattleUnit : MonoBehaviour 
{
    [SerializeField]
    private BattleStats battleStats;

    [SerializeField]
    private int health;

    public bool IsDead { get { return health <= 0; } }

    private void Start()
    {
        // set the starting health
        health = battleStats.MaxHealth;

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    public void ReceiveHealth(int amount)
    {
        health += amount;
    }
}
