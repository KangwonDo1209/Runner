using UnityEngine;

public class NonLoopObject : Moveable
{
	private float DestroyX = -15f;

	void Start()
	{
	}

	protected override void Update()
	{
		base.Update();
		if (transform.position.x <= DestroyX)
		{
			Destroy(gameObject);
		}
	}
}
