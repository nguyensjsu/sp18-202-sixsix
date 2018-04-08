using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Wave[] waves;
	public Enemy enemy;

	int enemiesRemainingToSpawn;
	float nextSpawnTime;

	void Update() {
	}

	[System.Serializable]
	public class Wave {
		public int enemyCount;
		public float timeBetweenSpawns;
	}
}