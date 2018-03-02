using UnityEngine;

public class Battle : MonoBehaviour 
{
    // the battle board
    [SerializeField]
    private BattleBoard battleBoard;

    // battle players
    [SerializeField]
    private BattlePlayer[] battlePlayers;

    // current player
    private int currentPlayerIndex = 0;
    public BattlePlayer CurrentBattlePlayer { get { return battlePlayers[currentPlayerIndex]; } }

    // the battle ui
    [SerializeField]
    private BattleUI battleUI;

    // ui delegates
    private delegate void OnPlayer(BattlePlayer player);
    private OnPlayer onPlayerTurnStart;

    private void Awake()
    {
        // add listener for tiles being selected
        battleBoard.onBoardTileSelected += OnBoardTileSelected;

        // add listeners to update ui
        onPlayerTurnStart += battleUI.OnSetCurrentPlayer;

        // start the battle
        StartBattle();
    }

    private void StartBattle()
    {
        // set the first player as the current
        onPlayerTurnStart(battlePlayers[currentPlayerIndex]);
    }

    private void ProgressTurn()
    {
        ++currentPlayerIndex;
        if (currentPlayerIndex > 1)
            currentPlayerIndex = 0;

        // update current to anything listening
        onPlayerTurnStart(CurrentBattlePlayer);
    }

    private void OnBoardTileSelected(BattleBoardTile tile)
    {
        // TODO handle this tile being selected
        // depending on "battle state" we may be selecting an ally unit
        // possibly selecting a target or a space to move to
        Debug.Log(CurrentBattlePlayer.DisplayName + " selected a tile");
        ProgressTurn();
    }
}
