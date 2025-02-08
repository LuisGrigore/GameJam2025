using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ritmo : MonoBehaviour
{
	/*public AudioSource Samba;
	public AudioSource MusicaFondo;
	public AudioSource MusicaVictoria;
	public AudioSource MusicaDerrota;

	public bool Empieza;

	public CarnivalDance BeatS;

	public static Ritmo instance;

	public int Dinero;
	public int DineroporNota = 100;
	public int DineroporNotaBuena = 125;
	public int DineroporNotaPerfecta = 150;

	public int Multi;
	public int Multiestado;
	public int[] Multicombo;

	public Text DineroTexto;
	public Text MultiTexto;

	public float NotasPerfectas;
	public float NotasBuenas;
	public float NotasNormales;
	public float NotasMalas;
	public float NotasTotales;

	public GameObject PanelFin;
	public GameObject PanelInicio;
	public Button BotonReiniciar;
	public Text NotasPorcentaje, NotasPerfectasTexto, NotasBuenasTexto, NotasNormalesTexto, NotasMalasTexto, rangoTexto , DineroTextoFinal;
	void Start()
	{
		instance = this;

		DineroTexto.text = "0";
		PanelInicio.SetActive(true);
		PanelFin.SetActive(false);
		Samba.Stop();
		MusicaFondo.Play();

		BotonReiniciar.onClick.AddListener(VolverAJugar);
	}

	void Update()
	{
		if(!Empieza)
		{
			if(Input.anyKeyDown)
			{
				Empieza = true;
				BeatS.isDancing = true;
				Samba.Play();
				MusicaFondo.Stop();
				PanelInicio.SetActive(false);
			}
		}
		else
		{
			if(!Samba.isPlaying && !PanelFin.activeInHierarchy)
			{
				PanelFin.SetActive(true);
				BotonReiniciar.gameObject.SetActive(true);

				NotasTotales = NotasPerfectas + NotasBuenas + NotasNormales + NotasMalas;
				float Porcentaje = (NotasPerfectas + NotasBuenas + NotasNormales) / NotasTotales * 100f;
				NotasPorcentaje.text = Porcentaje.ToString("F1") + "%";
				NotasPerfectasTexto.text = NotasPerfectas.ToString();
				NotasBuenasTexto.text = NotasBuenas.ToString();
				NotasNormalesTexto.text = NotasNormales.ToString();
				NotasMalasTexto.text = NotasMalas.ToString();
				
				string rango = "F";
				if(Porcentaje == 100)
				{
					rango = "SS";
				}
				else if(Porcentaje >= 90)
				{
					rango = "S";
				}
				else if(Porcentaje >= 80)
				{
					rango = "A";
				}
				else if(Porcentaje >= 70)
				{
					rango = "B";
				}
				else if(Porcentaje >= 50)
				{
					rango = "C";
				}
				else if(Porcentaje >= 49)
				{
					rango = "D";
				}
				rangoTexto.text = rango;
				DineroTextoFinal.text = Dinero.ToString();
				if(rango == "D")
				{
					MusicaDerrota.Play();
				}
				else
				{
					MusicaVictoria.Play();
				}
			}
		}
	}

	public void VolverAJugar()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	public void NotaBien()
	{

		if (Multi - 1 < Multicombo.Length)
		{
			Multiestado++;
			if (Multicombo[Multi - 1] <= Multiestado)
			{
				Multiestado = 0;
				Multi++;
			}
		}
		MultiTexto.text = "x" + Multi;
		DineroTexto.text = "" + Dinero;
	}

	public void NotaNormal()
	{
		Debug.Log("Nota Normal");
		Dinero += DineroporNota * Multi;
		NotaBien();
		NotasNormales++;
	}

	public void NotaBuena()
	{
		Debug.Log("Nota Buena");
		Dinero += DineroporNotaBuena * Multi;
		NotaBien();
		NotasBuenas++;
	}

	public void NotaPerfecta()
	{
		Debug.Log("Nota Perfecta");
		Dinero += DineroporNotaPerfecta * Multi;
		NotaBien();
		NotasPerfectas++;
	}
	public void NotaMal()
	{
		Debug.Log("Nota Mal");
		Multi = 1;
		Multiestado = 0;
		MultiTexto.text = "x" + Multi;
		NotasMalas++;
	}*/
}
