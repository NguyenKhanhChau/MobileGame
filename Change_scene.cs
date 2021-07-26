using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_scene : MonoBehaviour
{
	private int count;
	private int i_count;
	public Save_Point_Check ck_1 ;
	public Save_Point_Check ck_2 ;
	public Save_Point_Check ck_3 ;

	void Start()
	{
		count = 0;
		StartCoroutine(loop()) ;
	}

	IEnumerator loop()
	{
		for (;;)
		{
			if (GameObject.FindWithTag("Player") == null)
			{
				SceneManager.LoadScene("Result_Lose");
			}
			else if (ck_1.play_flag && ck_2.play_flag && ck_3.play_flag)
			{
				SceneManager.LoadScene("Result");
			}
			yield return new WaitForSeconds(3.0f);
		}
	}
}
