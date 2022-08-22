namespace Exercise013
{
    public class Item
    {

        private string identifier;
        private string name;

        public Item(string identifier, string name)
        {
            this.identifier = identifier;
            this.name = name;
        }
        public override string ToString()
        {
            return this.identifier + ": " + this.name;
        }

        public override bool Equals(object compared)
        {
            //compare with Item.identifier
            if (!(compared is Item)) return false;
            if (this == compared) return true;
            if(compared == null) return false;
            Item comparedItem = (Item)compared;
            if (this.identifier == comparedItem.identifier)
            {
                return true;
            }
            return false;

            
        }
    }

}
