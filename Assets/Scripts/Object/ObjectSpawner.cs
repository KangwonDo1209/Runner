using System.Collections;
using UnityEngine;
using Singleton;

public class ObjectSpawner : MonoBehaviour
{
	[SerializeField] private float minDelay;
	[SerializeField] private float maxDelay;
	[SerializeField] private GameObject[] prefabs;
	[SerializeField] private Vector3 spawnPoint;
	[SerializeField] private bool randomHeight;
	[SerializeField] private float minY;
	[SerializeField] private float maxY;

	private Coroutine spawnCoroutine;

	public void StartSpawnCoroutine()
	{
		spawnCoroutine = StartCoroutine(SpawnPeriodically(minDelay, maxDelay));
	}
	public void StopSpawnCoroutine()
	{
		StopCoroutine(spawnCoroutine);
	}
	private void SpawnObject(Vector3 spawnPosition)
	{
		Vector3 point = spawnPosition;
		if (randomHeight)
		{
			point.y = Mathf.Lerp(minY, maxY, Random.value);
		}
		int idx = Random.Range(0, prefabs.Length);
		Instantiate(prefabs[idx], point, prefabs[idx].transform.rotation);
	}
	private IEnumerator SpawnPeriodically(float min, float max)
	{
		if (min < 0.05f || max < 0.05f)
			yield break;
		while (true)
		{
			float time = Mathf.Lerp(min, max, Random.value);
			yield return new WaitForSeconds(time);
			SpawnObject(spawnPoint);

		}
	}
}
