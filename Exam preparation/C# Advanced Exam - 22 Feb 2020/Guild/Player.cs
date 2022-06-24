using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        private string name;
        private string @class;
        private string rank;
        private string description;

        public Player(string name, string @class)
        {
            this.Name = name;
            this.Class = @class;
            this.Rank = "Trial";
            this.Description = "n/a";
        }

        public string Name { get => name; set => name = value; }
        public string Class { get => @class; set => @class = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Description { get => description; set => description = value; }
        public override string ToString()
        {
            return $"Player {this.Name}: {this.Class}" + Environment.NewLine +
                $"Rank: {this.Rank}" + Environment.NewLine +
                $"Description: {this.Description}".Trim();
        }
    }
}
