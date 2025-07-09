using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
	public Animator birdAnimator;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			birdAnimator.SetBool("isFlying", true);
			//StartCoroutine(ResetFlying());
		}

		if (Input.GetKeyUp(KeyCode.Space))
		{
			birdAnimator.SetBool("isFlying", false);
		}
	}

	//IEnumerator ResetFlying()
	//{
	//	yield return new WaitForSeconds(0.2f); // adjust to your animation length
	//	birdAnimator.SetBool("isFlying", false);
	//}
}
