using UnityEngine;
using Singleton;
public class PlayerController : Singleton<PlayerController>
{
	public float jumpPower;
	private bool isGrounded = true;
	private bool _isGrounded
	{
		get
		{
			return isGrounded;
		}
		set
		{
			isGrounded = value;
			animator.SetBool("isGrounded", isGrounded);
		}
	}
	private Rigidbody2D rigid;
	[HideInInspector]
	public Animator animator;
	RigidbodyConstraints2D originalConstrains;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		animator = GetComponent<Animator>();
		originalConstrains = rigid.constraints;
	}
	public void Jump()
	{
		if (_isGrounded && InGameManager.Instance.isGaming)
		{
			_isGrounded = false;
			rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
		}

	}
	public void FreezeY()
	{
		rigid.constraints = originalConstrains | RigidbodyConstraints2D.FreezePositionY;
	}
	public void BreakY()
	{
		rigid.constraints = originalConstrains;
		rigid.AddForce(-Vector2.up * 0.1f, ForceMode2D.Impulse);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			_isGrounded = true;
		}
	}

	private void OnCollisionExit2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Ground"))
		{
			_isGrounded = false;
		}
	}
}
