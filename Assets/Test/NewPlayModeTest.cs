using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewPlayModeTest {

	[Test]
	public void NewPlayModeTestSimplePasses() {
		// Use the Assert class to test conditions.
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator NewPlayModeTestWithEnumeratorPasses() {
		SetupScene ();
		var menuHolder = new GameObject ().AddComponent<mainMenuHolder> ();
	}

	void SetupScene(){
		
	}

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
