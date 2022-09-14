using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class responder : MonoBehaviour {

	private int idTema;

	public Text pergunta;
	public Text RespostaA;
	public Text RespostaB;
	public Text infoResposta;

	public string[] perguntas;        //aremazena todas as peruntas
	public string[] alternativaA;    //armazena todas as alternativas A
	public string[] alternativaB;    //armazena todas as alternativas B
	public string[] corretas;       ////armazena todas as corretas

	private int idPergunta;

	private float acertos;
	private float questoes;
	private float media;
	private int notaFinal;


	// Use this for initialization
	void Start () {
		idTema = PlayerPrefs.GetInt("idTema");
		idPergunta = 0;
		questoes = perguntas.Length;

		pergunta.text = perguntas[idPergunta];
		RespostaA.text = alternativaA [idPergunta];
		RespostaB.text = alternativaB [idPergunta];

		infoResposta.text = "Respondendo "+(idPergunta + 1).ToString()+ " de "+questoes.ToString()+" perguntas.";
	}
	
	public void resposta(string alternativa)
	{

		if (alternativa == "A") 
		{
			if(alternativaA[idPergunta] == corretas[idPergunta])
			{
				acertos += 1;
			}
		}

		else if(alternativa == "B")
		{
			if(alternativaB[idPergunta] == corretas[idPergunta])
			{
				acertos += 1;
			}

		}

			proximaPergunta();

	}
	  
		void proximaPergunta()
		{
		idPergunta += 1;
		if (idPergunta <= (questoes-1)) {


			pergunta.text = perguntas [idPergunta];
			RespostaA.text = alternativaA [idPergunta];
			RespostaB.text = alternativaB [idPergunta];
			
			infoResposta.text = "Respondendo " + (idPergunta + 1).ToString () + " de " + questoes.ToString () + " perguntas.";
		} 
		else 
		{
			// oq fazer se terminar as perguntas
			media = 10 * (acertos/questoes); // calcula a media com base no percentual de acerto
			notaFinal = Mathf.RoundToInt (media);  // arredonda a nota para o proximo inteiro regra Mat

			if(notaFinal > PlayerPrefs.GetInt("notaFinal"+idTema.ToString()))
			{
				PlayerPrefs.SetInt ("notaFinal"+idTema.ToString(), notaFinal);
				PlayerPrefs.SetInt ("acertos"+idTema.ToString(), (int) acertos);
				PlayerPrefs.SetInt("questoes"+idTema.ToString(), (int) questoes );
	
				}
			PlayerPrefs.SetInt ("notaFinalTemp"+idTema.ToString(), notaFinal);
			PlayerPrefs.SetInt ("acertosTemp"+idTema.ToString(), (int) acertos);
			PlayerPrefs.SetInt("questoesTemp"+idTema.ToString(), (int) questoes );

			Application.LoadLevel("Nota Final");
		}
	}


}
