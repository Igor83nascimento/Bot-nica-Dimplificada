using UnityEngine;
using System.Collections;

public class comandosBasicos : MonoBehaviour {

	public void carregaCena(string nomeCena)
	{
		Application.LoadLevel (nomeCena);

	}

	public void resetarPontuacoes()
	{
		PlayerPrefs.DeleteAll();
	}
	public void SairDoJogo()
	{
		Application.Quit ();
	}

}