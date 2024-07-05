using UnityEngine;
using Singleton;
public class SpawnManager : Singleton<SpawnManager>
{
	// SpawnManager가 delay마다 spawnPoint에 Prefab을 Instantiate로 소환한다.

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
