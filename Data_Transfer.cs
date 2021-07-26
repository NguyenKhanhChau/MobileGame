using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Transfer : MonoBehaviour
{
	public int SEL_EXP_SUM;
	public int SEL_EXP_CUR;
	public int SEL_WEAPON_NO;
	public int SEL_MAGIC_NO;

	void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}

	void Start()
	{
		SEL_EXP_SUM = 10;
		SEL_EXP_CUR = 0;
		SEL_WEAPON_NO = 1;
		SEL_MAGIC_NO = 1;
	}
    public int getSEL_EXP_CUR()
    {
        return SEL_EXP_CUR;
    }

}
