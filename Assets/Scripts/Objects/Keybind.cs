using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Objects
{
    public class Keybind
    {
        private string actionName;
        private List<string> keys;
        private List<string> alternateKeys;

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
