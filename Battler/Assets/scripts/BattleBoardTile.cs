using UnityEngine;

public class BattleBoardTile : MonoBehaviour
{
    public delegate void OnTileSelect(BattleBoardTile tile);
    public OnTileSelect onTileSelect;

    private void Start()
    {
        SetUnselected();
    }

    private void OnMouseDown()
    {
        onTileSelect(this);
    }

    public void SetSelected()
    {
        transform.localScale = new Vector3(0.9f, 0.25f, 0.9f);
    }

    public void SetUnselected()
    {
        transform.localScale = new Vector3(1, 0.25f, 1);
    }
}
