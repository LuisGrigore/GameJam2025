using TMPro;
using UnityEngine;

public class PointManagerScript : MonoBehaviour
{
	[SerializeField] private TMP_Text pointText;
	[SerializeField] private TMP_Text comboText;

	[SerializeField] private GameObject gameManager;

	private void Start()
	{
		gameManager = GameObject.FindWithTag("GameManager");
	}

	public void updatePointText()
	{
		pointText.text = gameManager.GetComponent<GameManagerPlayerStatsScript>().getPoints().ToString();
	}
	public void updateComboText()
	{
		comboText.text = "x" + gameManager.GetComponent<GameManagerPlayerStatsScript>().getCurrentCombo().ToString();
	}
}