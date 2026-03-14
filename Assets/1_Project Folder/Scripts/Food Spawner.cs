using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class FoodSpawner : Singleton<FoodSpawner>
{
    [SerializeField] GameObject foodPrefab;

    GameObject spawnedFood;
    public void SpawnFood()
    {
        Vector2 position = GridSystem.Instance.GetRandomPosition();

        if (spawnedFood != null) Destroy(spawnedFood);
        spawnedFood = Instantiate(foodPrefab, position, Quaternion.identity);

        SnakeController.Instance.FoodPosition = position;
    }
    public void ResetFood()
    {
        if (spawnedFood != null) Destroy(spawnedFood);
        spawnedFood = null;
    }
}
