using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class FoodSpawner : Singleton<FoodSpawner>
{
    [SerializeField] GameObject foodPrefab;

    private void Start()
    {
        InputManager.OnEscape += SpawnFood;
    }
    public void SpawnFood()
    {
        Vector2 position = GridSystem.Instance.GetRandomPosition();

        GameObject food = Instantiate(foodPrefab, position, Quaternion.identity);
    }
}
