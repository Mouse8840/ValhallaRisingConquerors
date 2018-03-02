using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour 
{
    [SerializeField]
    private Text currentPlayerText;

    public void OnSetCurrentPlayer(BattlePlayer player)
    {
        currentPlayerText.text = player.DisplayName;
    }
}
