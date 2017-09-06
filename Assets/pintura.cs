using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

public class pintura : MonoBehaviour {

	public void mOver()
	{
		Color c;
		ColorUtility.TryParseHtmlString("#0099d6",out c );
		this.gameObject.GetComponent<Text> ().color = c;
	}

	public void mAfuera()
	{
		this.gameObject.GetComponent<Text> ().color = Color.white;
	}
}
