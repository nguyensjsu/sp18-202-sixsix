using UnityEngine;

public interface IDamageable {

	void TakeHit (float damage, RaycastHit hit);

	// add by Na
	void TakeDamage (float damage);

}
