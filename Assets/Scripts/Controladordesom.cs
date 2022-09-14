using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Controladordesom : MonoBehaviour 

{
	private bool estadoSom = true;
	[SerializeField] private AudioSource fundoMusical;

	[SerializeField] private Sprite SomLigadoSprite;
	[SerializeField] private Sprite SomDesigadoSprite;

	[SerializeField] private Image muteImage;

	public void LigarDesligarSom()

	{
		estadoSom = !estadoSom;
		fundoMusical.enabled = estadoSom;

		if (estadoSom) 
		{
			muteImage.sprite = SomLigadoSprite; 
		}
		else 
		{
	muteImage.sprite = SomDesigadoSprite;			 

    }
  }

}
