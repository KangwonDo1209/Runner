using UnityEngine;

public class Moveable : MonoBehaviour
{
	private static float moveSpeed = 5.0f;
	private static Vector2 moveDirection = Vector2.left;

	public float _MoveSpeed => moveSpeed;
	public Vector2 _MoveDirection => moveDirection;
	protected virtual void Update() { Move(); }
	protected static void SetMoveSpeed(float speed) { moveSpeed = speed; }
	protected void Move()
	{
		if (InGameManager.Instance.isGaming)
			transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
	}


}
