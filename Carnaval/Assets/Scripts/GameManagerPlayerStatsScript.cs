using UnityEngine;
using UnityEngine.Events;


public class GameManagerPlayerStatsScript : MonoBehaviour
{

	private static int PERFECT_POINTS = 10;
	private static int GOOD_POINTS = 5;
	private static int OK_POINTS = 1;
	private static int MISSED_POINTS = 0;


	[SerializeField] private UnityEvent onPointsChangedEvent;
	[SerializeField] private UnityEvent onComboChangedEvent;

	public void Start()
	{
		init();
		setPoints(2000);
		setCombo(5);
	}


	private int points { get; set; }
	private int currentCombo { get; set; }
	private int perfectCount { get; set; }
	private int goodCount { get; set; }
	private int okCount { get; set; }
	private int missedCount { get; set; }

	private void init()
	{
		points = 0;
		currentCombo = 0;
		perfectCount = 0;
		goodCount = 0;
		okCount = 0;
		missedCount = 0;
	}

	public int getPoints()
	{
		return points;
	}
	public int getCurrentCombo()
	{
		return currentCombo;
	}

	private void setPoints(int points)
	{
		this.points = points;
		onPointsChangedEvent?.Invoke();
	}

	private void setCombo(int combo)
	{
		this.currentCombo = combo;
		onComboChangedEvent?.Invoke();
	}

	public void resetCombo()
	{
		currentCombo = 0;
	}

	public void addCurrentCombo()
	{
		currentCombo ++;
	}
	public void addPerfectCount()
	{
		perfectCount ++;
		setPoints(PERFECT_POINTS + currentCombo);
	}
	public void addGoodCount() 
	{
		goodCount ++;
		setPoints(GOOD_POINTS + currentCombo);

	}
	public void addOkCount()
	{
		okCount ++;
		setPoints(OK_POINTS + currentCombo);
	}
	public void addMissedCount()
	{
		missedCount ++;
		setPoints(MISSED_POINTS + currentCombo);
	}

}

