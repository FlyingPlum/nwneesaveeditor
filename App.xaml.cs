using System.Windows;

namespace nwneesaveeditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

    }

    //Define Feat
    public class Feat
    {
        public Feat() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }

    //Define Spell
    public class Spell
    {
        public Spell() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //level flags
        public enum Level
        {
            Level0 = 1,
            Level1 = 2,
            Level2 = 4,
            Level3 = 8,
            Level4 = 16,
            Level5 = 32,
            Level6 = 64,
            Level7 = 128,
            Level8 = 256,
            Level9 = 512,
        }
        //class flags
        public enum Class
        {
            wizard = 1,
            cleric = 2,
            druid = 4,
            sorcer = 8,
            paladin = 16,
            ranger = 32,
            poet = 64,
        }
    }

    //json setting file decoding
    //open bic
    //transformation bic->json
    //transformation json->bic
    //edit json - add/remove feat
    //edit json - add/remove spell
    //save bic
    //close bic
}
