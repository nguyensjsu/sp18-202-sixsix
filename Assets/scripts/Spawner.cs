using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Wave[] waves;

	[System.Serializable]
	public class Wave {
		public int enemyCount;
		public float timeBetweenSpawns;
	}
}