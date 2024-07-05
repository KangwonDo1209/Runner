using UnityEngine;
using Singleton;
public class SpawnManager : Singleton<SpawnManager>
{
	// SpawnManager�� delay���� spawnPoint�� Prefab�� Instantiate�� ��ȯ�Ѵ�.

	public ObjectSpawner coinSpawner;
	public ObjectSpawner monsterSpawner;


	public void GameStart()
	{
		coinSpawner.StartSpawnCoroutine();
		monsterSpawner.StartSpawnCoroutine();
	}
	public void GameStop()
	{
		coinSpawner.StopSpawnCoroutine();
		monsterSpawner.StopSpawnCoroutine();
	}

}
