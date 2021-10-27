using System.Collections.Generic;

namespace CsharpConsoleTest
{
    public class Style
    {
       

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Field> Fields { get; set; }

        public Style(int id, string name, List<Field> fields)
        {
            Id = id;
            Name = name;
            Fields = fields;
        }
        
    }
}
