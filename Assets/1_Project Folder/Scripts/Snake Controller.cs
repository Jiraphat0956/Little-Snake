using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField] GameObject segmentPrefab;
    [SerializeField] List<Transform> segmentList = new List<Transform>();

    Vector2 currentDirection;
    void Start()
    {
        InputManager.OnMove += Move;
    }

    void Move(Vector2 direction)
    {
        currentDirection = direction;
        for (int i = segmentList.Count - 1; i > 0; i--)
        {
            segmentList[i].position = segmentList[i - 1].position;
        }
        transform.position = new Vector2(transform.position.x + direction.x, transform.position.y + direction.y);
        transform.eulerAngles = new Vector3(0, 0, Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg);
    }
}
