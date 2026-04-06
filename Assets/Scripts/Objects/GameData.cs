using UnityEngine;

public class GameData
{
    [SerializeField] private bool isCheated;
    [SerializeField] private bool isDevMode;
    [SerializeField] private bool isFirstRun;
    [SerializeField] private int runCount;
    [SerializeField] private int deathCount;
    [SerializeField] private int winCount;
    [SerializeField] private int resetCount;
    public GameData()
    {
        this.isCheated = false;
        this.isDevMode = false;
        this.isFirstRun = true;
        this.runCount = 0;
        this.deathCount = 0;
        this.winCount = 0;
        this.resetCount = 0;
    }
     public bool GetIsCheated { get { return isCheated; } }
     public bool SetIsCheated { set { isCheated = value; } }
     public bool GetIsDevMode { get { return isDevMode; } }
     public bool SetIsDevMode { set { isDevMode = value; } }
     public bool GetIsFirstRun { get { return isFirstRun; } }
     public bool SetIsFirstRun { set { isFirstRun = value; } }
     public int GetRunCount { get { return runCount; } }
     public int SetRunCount { set { runCount = value; } }
     public int GetDeathCount { get { return deathCount; } }
     public int SetDeathCount { set { deathCount = value; } }
     public int GetWinCount { get { return winCount; } }
     public int SetWinCount { set { winCount = value; } }
     public int GetResetCount { get { return resetCount; } }
     public int SetResetCount { set { resetCount = value; } }
}
