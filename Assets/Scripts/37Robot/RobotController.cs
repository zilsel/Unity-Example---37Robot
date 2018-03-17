using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour {

	public float robotSpeed;
	private Animator animator;
	private bool keyUpEvent;

	// Use this for initialization
	void Start () {
		this.animator = this.GetComponent<Animator>();
		if(this.animator != null)
		{
			this.animator.enabled = false;
			this.keyUpEvent = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			if(this.animator != null)
			{
				this.animator.enabled = true;
				this.keyUpEvent = false;
				this.animator.Play("37Robot_start_walking");
			}
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			if (this.animator != null)
			{
				this.keyUpEvent = false;
				this.transform.Translate(Vector3.forward * Time.deltaTime * this.robotSpeed);
				this.animator.Play("37Robot_walking");
			}
		}

		if (Input.GetKey(KeyCode.DownArrow))
		{
			if (this.animator != null)
			{
				this.keyUpEvent = false;
				this.transform.Translate(Vector3.back * Time.deltaTime * this.robotSpeed);
				this.animator.Play("37Robot_walking");
			}
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			if (this.animator != null)
			{
				this.keyUpEvent = false;
				this.transform.Rotate(Vector3.up * Time.deltaTime * this.robotSpeed);
				this.animator.Play("37Robot_walking");
			}
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			if (this.animator != null)
			{
				this.keyUpEvent = false;
				this.transform.Rotate(Vector3.up * Time.deltaTime * -this.robotSpeed);
				this.animator.Play("37Robot_walking");
			}
		}

		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			if (this.animator != null)
			{
				this.keyUpEvent = true;
			}
		}
	}

	public void WalkingFinished()
	{
		if(this.keyUpEvent)
		{
			this.animator.Play("37Robot_stop_walking");
		}
	}
}