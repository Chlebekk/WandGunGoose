using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Objects
{
    public class Keybind
    {
        [SerializeField] private string actionName;
        [SerializeField] private List<string> keys;
        [SerializeField] private List<string> alternateKeys;

        public Keybind(string actionName, List<string> keys)
        {
            this.actionName = actionName;
            this.keys = keys;
            this.alternateKeys = new List<string>();
        }
        public string GetActionName { get { return actionName; } }
        public string SetActionName { set { actionName = value; } }
        public List<string> SetKeys { set { keys = value; } }
        public List<string> GetKeys { get { return keys; } }
        public List<string> GetAlternateKeys { get { return alternateKeys; } }
        public List<string> SetAlternateKeys { set { alternateKeys = value; } }

    }
}
