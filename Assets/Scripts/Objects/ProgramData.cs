using Assets.Scripts.Objects;
using System.Collections.Generic;
using UnityEngine;

public class ProgramData
{
    [SerializeField] private float gameVolume;
    [SerializeField] private float sfxVolume;
    [SerializeField] private float musicVolume;
    [SerializeField] private List<Keybind> keybinds;
    public ProgramData()
    {
        this.gameVolume = 1.0f;
        this.sfxVolume=1.0f;
        this.musicVolume=1.0f;
        this.keybinds = new List<Keybind>();
        Initialkeybinds();
    }
    private void Initialkeybinds()
    {
        this.keybinds.Add(new Keybind("Move Up", new List<string> { "W"}));
        this.keybinds.Add(new Keybind("Move Down", new List<string> { "S"}));
        this.keybinds.Add(new Keybind("Move Left", new List<string> { "A"}));
        this.keybinds.Add(new Keybind("Move Right", new List<string> { "D"}));
        this.keybinds.Add(new Keybind("Use Active Item", new List<string> { "Space" }));
        this.keybinds.Add(new Keybind("Interact", new List<string> { "Mouse1" }));
        this.keybinds.Add(new Keybind("Inspect", new List<string> { "Mouse2" }));
        this.keybinds.Add(new Keybind("Pause", new List<string> { "Escape" }));
        this.keybinds.Add(new Keybind("Open Inventory", new List<string> { "I" }));
        this.keybinds.Add(new Keybind("Restart Run", new List<string> { "R" }));
    }
        public float GetGameVolume { get { return gameVolume; } }
        public float SetGameVolume { set { gameVolume = value; } }
        public float GetSfxVolume { get { return sfxVolume; } }
        public float SetSfxVolume { set { sfxVolume = value; } }
        public float GetMusicVolume { get { return musicVolume; } }
        public float SetMusicVolume { set { musicVolume = value; } }
        public List<Keybind> GetKeybinds { get { return keybinds; } }
        public Keybind GetKeybind(string actionName)
        {
            foreach (Keybind keybind in keybinds)
            {
                if (keybind.GetActionName == actionName)
                {
                    return keybind;
                }
            }
            return null;
        }
        public void SetKeybind(string actionName, List<string> keys)
        {
            foreach (Keybind keybind in keybinds)
            {
                if (keybind.GetActionName == actionName)
                {
                    keybind.SetKeys = keys;
                    return;
                }
            }
        }
        public void SetAlternateKeybind(string actionName, List<string> keys)
        {
            foreach (Keybind keybind in keybinds)
            {
                if (keybind.GetActionName == actionName)
                {
                    keybind.SetAlternateKeys = keys;
                    return;
                }
            }
        }
        public List<string> GetAlternateKeybind(string actionName)
        {   
            foreach (Keybind keybind in keybinds)
            {
                if (keybind.GetActionName == actionName)
                {
                    return keybind.GetAlternateKeys;
                }
            }
            return null;
        }
}
