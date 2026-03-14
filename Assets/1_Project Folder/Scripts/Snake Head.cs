using UnityEngine;

public class SnakeHead : MonoBehaviour
{
    [SerializeField] LayerMask layerMask;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((layerMask.value & (1 << collision.gameObject.layer)) > 0)
        {
            SnakeController.Instance.OnSnakeDead?.Invoke();
        }
    }
}
