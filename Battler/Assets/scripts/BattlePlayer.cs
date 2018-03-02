using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : MonoBehaviour {
    [SerializeField]
    private string displayName;
    public string DisplayName { get { return displayName; } }

    [SerializeField]
    private List<BattleUnit> units;

    public bool IsDead 
    { 
        get
        {
            int aliveCount = 0;
            foreach (BattleUnit unit in units)
            {
                if (unit.IsDead)
                {
                    aliveCount++;
                }
            }

            // the player is dead when they have 0 alive units
            return (aliveCount == 0); 
        }
    }
}
