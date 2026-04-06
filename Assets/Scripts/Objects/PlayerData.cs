using UnityEngine;

public class PlayerData
{
    [SerializeField] private int playerLevel;
    [SerializeField] private int playerXp;
    [SerializeField] private int playerHealth;
    [SerializeField] private int playerMaxHealth;
    [SerializeField] private int playerMp;
    [SerializeField] private int playerMaxMp;
    [SerializeField] private int playerGold;
    public PlayerData()
    {
        this.playerLevel = 1;
        this.playerXp = 0;
        this.playerHealth = 100;
        this.playerMaxHealth = 100;
        this.playerMp = 50;
        this.playerMaxMp = 50;
        this.playerGold = 0;
    }
     public int GetPlayerLevel { get { return playerLevel; } }
     public int SetPlayerLevel { set { playerLevel = value; } }
     public int GetPlayerXp { get { return playerXp; } }
     public int SetPlayerXp { set { playerXp = value; } }
     public int GetPlayerHealth { get { return playerHealth; } }
     public int SetPlayerHealth { set { playerHealth = value; } }
     public int GetPlayerMaxHealth { get { return playerMaxHealth; } }
     public int SetPlayerMaxHealth { set { playerMaxHealth = value; } }
     public int GetPlayerMp { get { return playerMp; } }
     public int SetPlayerMp { set { playerMp = value; } }
     public int GetPlayerMaxMp { get { return playerMaxMp; } }
     public int SetPlayerMaxMp { set { playerMaxMp = value; } }
     public int GetPlayerGold { get { return playerGold; } }
     public int SetPlayerGold { set { playerGold = value; } }
}
