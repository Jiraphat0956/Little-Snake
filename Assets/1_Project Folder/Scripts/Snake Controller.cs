using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    [SerializeField] GameObject segmentPrefab;
    [SerializeField] List<Transform> segmentList = new List<Transform>();

    Vector2 currentDirection;
    void Start()
    {
        InputManager.OnMove += Move;
        InputManager.OnEscape += Grow;
    }

    void Move(Vector2 direction)
    {
        Transform firstSegment = segmentList.First();

        if (direction == -currentDirection) return;
        currentDirection = direction;
        for (int i = segmentList.Count - 1; i > 0; i--)
        {
            segmentList[i].position = segmentList[i - 1].position;
            segmentList[i].rotation = segmentList[i - 1].rotation;
        }
        firstSegment.position = new Vector2(firstSegment.position.x + direction.x, firstSegment.position.y + direction.y);
        firstSegment.eulerAngles = new Vector3(0, 0, Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg);
    }

    void Grow()
    {
        Transform lastSegment = segmentList.Last();

        Vector2 newSegmentPosition = lastSegment.position - lastSegment.TransformDirection(Vector2.up);

        GameObject newSegment = Instantiate(segmentPrefab, newSegmentPosition, lastSegment.rotation);
        newSegment.transform.SetParent(transform);
        segmentList.Add(newSegment.transform);
    }
}
