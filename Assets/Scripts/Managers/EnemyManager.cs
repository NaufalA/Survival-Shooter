using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    [SerializeField] private MonoBehaviour factory;
    IFactory Factory => factory as IFactory;

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), spawnTime, spawnTime);
    }


    private void Spawn()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }

        // var spawnPointIndex = Random.Range(0, spawnPoints.Length);
        var spawnEnemy = Random.Range(0, 3);

        Factory.FactoryMethod(spawnEnemy);
    }
}