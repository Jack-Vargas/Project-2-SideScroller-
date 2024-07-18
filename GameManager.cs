using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {  get; private set; }


    public int gearSC { get; private set; }
    public int gears;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate (gameObject);
        }

        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void GearGet()
    {
        gearSC += 1;
        gears += 2;
    }

    void Update()
    {
        int gears = gearSC;
        PlayerManeger TargetScript = FindObjectOfType<PlayerManeger>();
        TargetScript.GearSet(gears);
    }
}
