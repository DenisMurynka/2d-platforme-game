using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BombsAway.Properties;
//using WMPLib;
using System.IO;
//using MySql.Data.MySqlClient;


namespace lab_4_24
{

    class Instr
    {
        public string Name { get; set; }

        public Instr(string name)
        {
            Name = name;
        }
        public int price;
        private int Year;
        public string Color;
        public bool musicStaf = false;
        public bool workStaf = false;
        public void About()
        {

            Console.WriteLine("Hello");
        }
    }
    //C:\Users\77\source\repos\lab_4-24
    #region WORKSTAF
    class WorkStaf : Instr
    {

        public WorkStaf(string name) : base(name)
        {
            this.Name = name;
            //this.Year = year;
        }
        public void init()
        {
            workStaf = true;
        }
        public void AboutWorkStaf()
        {
            Console.WriteLine(" инструменты, используемые преимущественно при производстве строительных, монтажных и ремонтно-строительных работ.");
        }
    }
    class HandWorkStaf : WorkStaf
    {
        bool doubleCarryStaf = false;
        string pryvidRoboty;
        public HandWorkStaf(string name) : base(name)
        {
            this.Name = name;

        }
    }
    class MachineWorkStaf : WorkStaf
    {
        bool elecroWork = false;
        bool gasWork = false;
        string Prednoznchenie;
        public MachineWorkStaf(string name) : base(name)
        {
            this.Name = name;

        }
    }

    #endregion
    #region MUSICSTAF
    class MusicStaf : Instr
    {
        public MusicStaf(string name) : base(name)
        {
            this.Name = name;
        }
        public void init()
        {
            musicStaf = true;
        }
        public void aboutMusicStaf()
        {
            Console.WriteLine("Im from MusicStaf");
        }
    }
    class ElectroMusicStaf : MusicStaf
    {
        public string playSyle;
        public string pedalEfects;
        public ElectroMusicStaf(string name) : base(name)
        {
            this.Name = name;
        }
        public void aboutElectroMusicStaf()
        {
            Console.WriteLine("Електрогітара — електричний музичний інструмент, різновид гітари з електричними звукознімачами, що перетворюють коливання металевих струн на коливання електричного струму. Сигнал зі звукознімачів може бути оброблений для отримання різних звукових ефектів та підсилений для відтворення через динаміки. Слово «електрогітара» виникло від словосполучення «електрична гітара».");
        }
    }
    class AcusticMusicStaf : MusicStaf
    {
        System.Media.SoundPlayer acusticguitarSound = new System.Media.SoundPlayer("C:/ Users / 77 / Downloads / Telegram Desktop / 1.wav");
       // acusticguitarSound.SoundLocation = "C:/Users/77/Downloads/Telegram Desktop/1.wav";
        public string korpus;

        public AcusticMusicStaf(string name) : base(name)
        {
            this.Name = name;
        }
        public void aboutElectroMusicStaf()
        {
            Console.WriteLine("Акустична гітара — струнний щипковий музичний інструмент (у більшості різновидів з шістьма струнами) з сімейства гітар, звучання якого здійснюється завдяки коливання струн, яке посилюється за рахунок резонування порожнистого корпусу. Сучасні акустичні гітари можуть мати вбудовані звукознімачі: магнітні або п'єзоелектричні, з еквалайзером і регулятором гучності. У більш вузькому понятті — окремий клас гітари з металевими струнами і корпусами типу Дредноут, Фолк і Джамбо.");
        }
        public void playAcusticMucis()
        {
            acusticguitarSound.Play();

        }
    }
    #endregion
    class Program
    {
        public static void Main(string[] args)
        {
            WorkStaf molotok = new WorkStaf("Molotok");
            molotok.price = 77;
            MusicStaf guitar = new MusicStaf("Groza");
            AcusticMusicStaf gg = new AcusticMusicStaf("Test");
            gg.playAcusticMucis();
            ElectroMusicStaf rockGuitar = new ElectroMusicStaf(" GROM");
            rockGuitar.Color = "red";

        }


    }
}
