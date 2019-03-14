using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor
{
    class Songs
    {
        private String name;
        private String duration;
        private String artist;
        private String album;
        private int year;
        private String genre;
        
        public Songs()
        {
            name = "";
            duration = "";
            artist = "";
            album = "";
            year = 0;
            genre = "";
        }

        public void fillData(Random rand)
        {
            //Llenar los datos de forma aleatoria
            String[] gn = new String[4];
            gn[0] = "Rock";
            gn[1] = "Pop";
            gn[2] = "Metal";
            gn[3] = "Disco";

            Name = "Default" + rand.Next(0,50);
            Duration = rand.Next(1,3) + ":" + rand.Next(10,59);
            Artist = "Default" + rand.Next(0,10);
            Album = "Defualt" + rand.Next(0,10);
            year = rand.Next(1960,2015);
            genre = gn[rand.Next(0, 4)];

        }

        public String Name { get => name;
            set => name = value;
        }
        public String Duration { get => duration;
            set => duration = value;
        }
        public String Album
        {
            get => album;
            set => album = value;
        }
        public String Artist {
            get => artist;
            set => artist = value;
        }
        public int Year {
            get => year;
            set => year = value;
        }
        public String Genre {
            get => genre;
            set => genre = value;
        }
    }
}
