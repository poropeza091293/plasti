 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nav : MonoBehaviour {

	GameObject m,c;

	// Use this for initialization
	void Start () 
	{
		if(SceneManager.GetActiveScene().name=="dos")
		{
			m = GameObject.Find ("mexico");
			c=  GameObject.Find ("centroa");

			m.SetActive (false);
			c.SetActive (false);
		}
		
	}


	public void pinMexico()
	{
		if (m.activeSelf)
			m.SetActive (false);
		else
			m.SetActive (true);
	}

	public void pinCentroAmerica()
	{
		if (c.activeSelf)
			c.SetActive (false);
		else
			c.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void lugares()
	{
		SceneManager.LoadScene ("dos");
	}

	public void menuInicial()
	{
		SceneManager.LoadScene ("menu");
	}


	public void Queretaro()
	{
		SceneManager.LoadScene ("queretaro");
	}

	public void Guadalajara()
	{
		SceneManager.LoadScene ("guadalajara");
	}

	public void Tlaxcala()
	{
		SceneManager.LoadScene ("tlaxcala");
	}

	public void Mexico()
	{
		SceneManager.LoadScene ("mexico");
	}

	public void CostaRica()
	{
		SceneManager.LoadScene ("costarica");
	}

	public void ElSalvador()
	{
		SceneManager.LoadScene ("elsalvador");
	}

	public void CentroAmerica()
	{
		SceneManager.LoadScene ("centroamerica");
	}

	public void Final()
	{
		SceneManager.LoadScene ("final");
	}


	public void registro()
	{

		Application.ExternalEval ("window.open(\"http://acob.guru/Pangea/startplastimagen2017.asp\",\"_blank\")");
	}



}
