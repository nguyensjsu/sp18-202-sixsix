using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewEditModeTest {

	[Test]
	public void NewEditModeTestSimplePasses() {
		// Use the Assert class to test conditions.
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode


	[UnityTest]
	public IEnumerator GameObject_WithRigidBody_WillBeAffectedByPhysics()
	{
		var go = new GameObject();
		go.AddComponent<Rigidbody>();
		var originalPosition = go.transform.position.y;

		yield return new WaitForFixedUpdate();

		Assert.AreNotEqual(originalPosition, go.transform.position.y);
	}
}
