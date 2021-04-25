using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bat : MonoBehaviour
{
	public Animator BatAnimator;
	public SpriteRenderer sr;
	public float moveSpeed = 5f;
	private Vector3 startPosition;
	

	private void Start()
	{
		startPosition = transform.position;
	}

	private void Awake()
	{
		sr = GetComponent<SpriteRenderer>();
	}

	private void Update()
	{
		float Air = transform.position.y;
		float moveDir = Input.GetAxis("Horizontal"); //Set in Edit -> Project Settings -> Input
		if(moveDir < 0f)
		{
			transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0f, 0f);
			BatAnimator.SetInteger("State", 1);
			sr.flipX = true;
		}
		else if (moveDir > 0f)
		{
			transform.position += new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
			BatAnimator.SetInteger("State", 1);
			sr.flipX = false;
		}
		else
		{
			BatAnimator.SetInteger("State", 0);
		}

		if(Input.GetKey(KeyCode.Space))
		{
			transform.position += new Vector3(0f, (moveSpeed*2f) * Time.deltaTime, 0f);
			if (Air > transform.position.y || Air < transform.position.y)
			{
				BatAnimator.SetInteger("State", 2);
			}

		}
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Reset"))
			{
				transform.position = startPosition;
			}
		
	
		//else if (collision.CompareTag("Finish"))
		//{
			//int scene = SceneManager.GetActiveScene().buildIndex;
			//SceneManager.LoadScene(scene+1);
			//if(scene == 4)
			//{
				//SceneManager.LoadScene(0);
			//}
		//}

	}
}
