using UnityEngine;

public class GridSystem : Singleton<GridSystem>
{
    [SerializeField] Vector2Int maxGridPosition;
    [SerializeField] Vector2Int minGridPosition;

    [SerializeField] bool showDebugGrid;

    public bool IsInsideGrid(Vector2 position)
    {
        return (position.x >= minGridPosition.x && position.x <= maxGridPosition.x)
            && (position.y >= minGridPosition.y && position.y <= maxGridPosition.y);
    }

    private void OnDrawGizmos()
    {
        if (!showDebugGrid) return;
        for(int i = minGridPosition.y;i < maxGridPosition.y; i++)
        {
            for(int j = minGridPosition.x; j < maxGridPosition.x; j++)
            {
                Gizmos.color = Color.yellow;
                Gizmos.DrawSphere(new Vector3(j, i, 0), .5f);
            }
        }
    }
}
