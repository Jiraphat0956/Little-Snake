using System.Collections.Generic;
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
    public Vector2Int GetRandomPosition()
    {
        List<Vector2Int> availableGridList = GetAvailableGridList();
        return availableGridList[Random.Range(0, availableGridList.Count)];
    }

    public List<Vector2Int> GetAvailableGridList()
    {
        List<Vector2Int> segmentList = SnakeController.Instance.GetSegmentList().ConvertAll(x => new Vector2Int((int)x.position.x, (int)x.position.y));

        List<Vector2Int> availableGridList = new List<Vector2Int>();
        for (int i = minGridPosition.x; i < maxGridPosition.x; i++)
        {
            for (int j = minGridPosition.y; j < maxGridPosition.y; j++)
            {
                if(!segmentList.Contains(new Vector2Int(i, j)))
                {
                    availableGridList.Add(new Vector2Int(i, j));
                }
            }
        }
        return availableGridList;
    }

    private void OnDrawGizmos()
    {
        if (!showDebugGrid) return;
        for(int i = minGridPosition.x;i < maxGridPosition.x; i++)
        {
            for(int j = minGridPosition.y; j < maxGridPosition.y; j++)
            {
                Gizmos.color = Color.yellow;
                Gizmos.DrawSphere(new Vector3(i, j, 0), .5f);
            }
        }
    }
}
