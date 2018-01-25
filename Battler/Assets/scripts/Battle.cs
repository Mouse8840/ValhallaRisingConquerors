using UnityEngine;

public class Battle : MonoBehaviour 
{
    // the battle board
    [SerializeField]
    private BattleBoard battleBoard;

    private void Awake()
    {
        battleBoard.onBoardTileSelected += OnBoardTileSelected;
    }

    private void OnBoardTileSelected(BattleBoardTile tile)
    {
        // TODO handle this tile being selected
        // depending on "battle state" we may be selecting an ally unit
        // possibly selecting a target or a space to move to
    }
}
