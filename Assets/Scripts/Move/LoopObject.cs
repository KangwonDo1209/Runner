using UnityEngine;

public class LoopObject : Moveable
{
	public bool AutoSizing;
	private Vector3 initialPosition;
	public float halfWidth;

	void Start()
	{
		initialPosition = transform.position;
		if (AutoSizing)
			halfWidth = GetComponent<Renderer>().bounds.size.x / 2; // 18.46154
	}

	protected override void Update()
	{
		base.Update();

		if (transform.position.x <= initialPosition.x - halfWidth)
		{
			transform.position = initialPosition;
		}
	}
}
