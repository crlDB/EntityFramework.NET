using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.EF00100_HelloWorld
{
    class Video
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    class MeContext : DbContext
    {
        public MeContext() : base(@"Data Source=.\sqlexpress;Initial Catalog=MyTestDb;Integrated Security=True")
        {

        }

        public DbSet<Video> Videos { get; set; }


    }
    
    
    
    public class Ef00100HelloWorld
    {
        // Entitiy framewordk
        //  -> schrijven en lezen van/naar database
        //  -> maak PODO's, 'plain old data object', klassen enkel met data die tabellen voorstellen in de database
        //  -> Context, pipeline to and from database, klasse derived van DbContext
        //  -> Laatste assembly download via NuGET
        //  -> via de file 'packages.config' kan je zien welk versie geinstalleerd is
        //  -> de referentie naar deze EF-assembly is automatisch toegevoegd
        //  -> in file 'using System.Data.Entity;'
        //  -> ctor, maak constructor en voeg connectionstring toe
        //  -> connectionstring bevat de plaats waar de database is geplaatst
        //  -> connectionstring moet provider bevatten ''
        //  -> voeg in de 'MeContext' de verschillende tabellen toe via een 'DbSet'
        //  -> zorg ervoor dat alle tabellen een primary-Key-veld hebben (ID)

        //  -> run programen EF zal een database/tabellen/velden volledig aanmaken

        //  -> EF is convention over configuration :
        //          prop met ID zijn automatisch primary-key
        //          ....




        public void Start()
        {


            var meContext = new MeContext();
            meContext.Database.Delete();

            var vid = new Video { Title = "Carl", Description = "old song" };
            meContext.Videos.Add(vid);
            vid = new Video { Title = "Efie", Description = "new song" };
            meContext.Videos.Add(vid);
            vid = new Video { Title = "Jenna", Description = "song 1995" };
            meContext.Videos.Add(vid);
            vid = new Video { Title = "Siebe", Description = "song 2003" };
            meContext.Videos.Add(vid);



            meContext.SaveChanges();



        }


    }
}
