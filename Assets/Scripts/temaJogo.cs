using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class temaJogo : MonoBehaviour {

	public Button	 btnplay;
	public Text		 txtNomeTema;

	public GameObject	 infoTema;
	public Text 		txtInfoTema;
	public GameObject   estrela1;
	public GameObject   estrela2;
	public GameObject   estrela3;


	public string[]		nomeTema;
	private int 		questoes;
	private int			idTema;


	// Use this for initialization
	void Start () {
		idTema = 0;
		txtNomeTema.text = nomeTema[idTema];
		infoTema.SetActive (false);
		estrela1.SetActive (false);
		estrela2.SetActive (false);
		estrela3.SetActive (false);
		btnplay.interactable = false;
		txtInfoTema.text = "Você acertou X de X questões!";
	}
	
	public void SelecioneTema(int i)
	{
	idTema = i;
	PlayerPrefs.SetInt("idTema", idTema);
	txtNomeTema.text = nomeTema[idTema];

		int notaFinal = PlayerPrefs.GetInt("notaFinal"+idTema.ToString ());
		int acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString ());
		int questoes = PlayerPrefs.GetInt("questoes" + idTema.ToString ()); 

		estrela1.SetActive (false);
		estrela2.SetActive (false);
		estrela3.SetActive (false);

		if(notaFinal == 10)

		{
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (true);
		} 
		
		else if (notaFinal >= 7) 
		{
			estrela1.SetActive (true);
			estrela2.SetActive (true);
			estrela3.SetActive (false);
		}
		else if (notaFinal >= 5) 
		{
			estrela1.SetActive (true);
			estrela2.SetActive (false);
			estrela3.SetActive (false);
			
			
		}



		txtInfoTema.text = "Você acertou "+acertos.ToString()+" de "+questoes.ToString()+" questões";
	infoTema.SetActive (true);
	btnplay.interactable = true;
	}
	public void jogar()
	{
	  Application.LoadLevel("T"+idTema.ToString());
	
	
	}



}