using UnityEngine;

public class BattleBoard : MonoBehaviour
{
    // on selected a tile
    public delegate void OnBoardTileSelected(BattleBoardTile tile);
    public OnBoardTileSelected onBoardTileSelected;

    // tile source
    [SerializeField]
    private BattleBoardTile tileSource;

    // board size
    [SerializeField]
    private int columns;
    [SerializeField]
    private int rows;

    private void Start()
    {
        // create the tiles
        for (int c = 0; c < columns; ++c)
        {
            for (int r = 0; r < rows; ++r)
            {
                BattleBoardTile tile = Instantiate(tileSource, transform);
                tile.transform.localPosition = new Vector3(c * 1.1f, 0, r * 1.1f);
                tile.onTileSelect += OnTileSelected;
            }
        }

        // adjust the board to position "centered" in front of the camera
        transform.localPosition = Vector3.left * (columns - 1) / 2.0f;
    }

    private void OnTileSelected(BattleBoardTile tile)
    {
        BroadcastMessage("SetUnselected", SendMessageOptions.DontRequireReceiver);
        tile.SetSelected();
        onBoardTileSelected(tile);
    }
}
