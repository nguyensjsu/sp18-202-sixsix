using System.Collections;
using UnityEngine;

public class SoundLibrary : MonoBehaviour {

	public SoundGroup[] soundGroups;

	public AudioClip GetClipFromName(string name) {

		return null;
	}

	[System.Serializable]
	public class SoundGroup {
		public string groupID;
		public AudioClip[] group;
	}
}
