using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;
        private string name;
        private int capacity;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Roster = new List<Player>();
        }

        public List<Player> Roster { get => roster; set => roster = value; }
        public string Name { get => name; set => name = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public int Count => this.roster.Count;
        public void AddPlayer(Player player)
        {
            if (roster.Count == this.Capacity)
            {
                return;
            }
            else
            {
                roster.Add(player);
            }
        }
        public bool RemovePlayer(string name)
        {
            int count = roster.RemoveAll(x => x.Name == name);
            return count > 0;
        }
        public void PromotePlayer(string name)
        {
            Player currentPlayer = roster.Find(x => x.Name == name);
            if (currentPlayer == null)
            {
                return;
            }
            if (currentPlayer.Rank != "Member")
            {
                currentPlayer.Rank = "Member";
            }
            else
            {
                return;
            }
        }
        public void DemotePlayer(string name)
        {
            Player currentPlayer = roster.Find(x => x.Name == name);
            if (currentPlayer == null)
            {
                return;
            }
            if (currentPlayer.Rank != "Trial")
            {
                currentPlayer.Rank = "Trial";
            }
            else
            {
                return;
            }
        }
        public Player[] KickPlayersByClass(string @class)
        {
            if(roster.Count == 0)
            {
                return null;
            }
            var arrayToReturn = roster.FindAll(x => x.Class == @class).ToArray();
            roster.RemoveAll(x => x.Class == @class);
            return arrayToReturn;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in roster)
            {
                sb.AppendLine(player.ToString().Trim());
            }
            return sb.ToString().Trim();
        }
    }
}
