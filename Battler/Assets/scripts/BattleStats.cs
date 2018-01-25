using UnityEngine;

[System.Serializable]
public class BattleStats
{
    [SerializeField]
    private int maxHealth;
    public int MaxHealth { get { return maxHealth; } }

    [SerializeField]
    private int movement;
    public int Movement { get { return movement; } }

    [SerializeField]
    private int damage;
    public int Damage { get { return damage; } }
}
