using UnityEngine;
using System.Collections;

public class Delay : MonoBehaviour {

	public GameObject redBall;
	public GameObject blueBall;
	public GameObject greenBall;
	public float waitTime;

	private bool timer = false;

	void Start()
	{
		Activate();
		StartCoroutine(Timer ());
	}

	void Update()
	{
		if (timer == true)
			Activate();
	}

	private IEnumerator Timer()
	{
		yield return new WaitForSeconds(waitTime);
		timer = true;
	}

	void Activate()
	{
		redBall.SetActive(timer);
		blueBall.SetActive(timer);
		greenBall.SetActive(timer);
	}
}
