using UnityEngine;
using System.IO;
using System.Collections;

public class timer : MonoBehaviour {

		


	private int tempoEspera = 7; // aqui vc coloca o tempo que quer ficar na tela da logo
		private float tempTime;
		
		void Update()
		{
			tempTime += Time.deltaTime;
			if(tempTime >= tempoEspera)
			{
			Application.LoadLevel("Titulo"); //em nome da cena coloca o titulo ou outra cena a sua escolha
			}
			
		}
		
	}
