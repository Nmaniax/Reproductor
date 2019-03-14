using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Form1 : Form
    {
        List<Songs> listSong = new List<Songs>();

        public Form1()
        {
            InitializeComponent();
            lvSetup();
            createSongs();
            showSongs();
            listViewSongs.Items[0].Selected = true;
        }
        

        private void createSongs()
        {
            //Se crean un i numero de canciones para llenar la lista
            int i = 0;
            Random rand = new Random();

            while( i < 10 )
            {
                Songs song = new Songs();
                song.fillData(rand);
                listSong.Add(song);
                i++;
            }
        }

        private void showSongs()
        {
            //En esta funcion se agregan canciones a el objecto ListView
            ListViewItem itm;
            String[] str = new String[2];
            foreach(Songs s in listSong)
            {
                str[0] = s.Name;
                str[1] = s.Duration;
                itm = new ListViewItem(str);
                listViewSongs.Items.Add(itm);
            }
        }

        private void lvSetup()
        {
            //Activamos la vista por columnas y se agregan las dos columnas en sus respectivas posiciones
            listViewSongs.View = View.Details;
            listViewSongs.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listViewSongs.Columns.Add("Duration", -2, HorizontalAlignment.Left);
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count == 0)         //Si esta vacio...
                return;
            listViewSongs.Focus();

            int s = listViewSongs.SelectedItems[0].Index;

            listViewSongs.Items[s].Selected = false;
            listViewSongs.SelectedItems.Clear();
            listViewSongs.Items[0].Selected = true;             //Ir al item en la posicion 0
            listViewSongs.Items[0].Focused = true;
            getListMetadata(0);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count == 0)
                return;
            listViewSongs.Focus();

            int s = listViewSongs.SelectedItems[0].Index;

            listViewSongs.Items[s].Selected = false;
            listViewSongs.SelectedItems.Clear();

            s = listSong.Count -1;                  //Tomamos el tamaño de la lista de canciones -1 y vamos a ese ultimo indice 
            listViewSongs.Items[s].Selected = true;
            listViewSongs.Items[s].Focused = true;
            getListMetadata(s);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count == 0)
                return;
            listViewSongs.Focus();
            int s = listViewSongs.SelectedItems[0].Index;       //Tomar el index del item actual

            listViewSongs.Items[s].Selected = false;

            if (s > 0)
                s--;
            listViewSongs.SelectedItems.Clear();
            listViewSongs.Items[s].Selected = true;             //Seleccionamos nuevo elemento
            listViewSongs.Items[s].Focused = true;
            getListMetadata(s);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Si la lista esta vacia...
            if (listViewSongs.SelectedItems.Count == 0)
                return;
            listViewSongs.Focus();      //Enfocamos a la lista

            int s = listViewSongs.SelectedItems[0].Index;       //Tomamos el index del objeto actualmente seleccionado

            listViewSongs.Items[s].Selected = false;            //Deseleccionamos el actual

            if (s < listViewSongs.Items.Count - 1)              //Si estamos en el limite no se permiten más movimientos
                s++;
            listViewSongs.SelectedItems.Clear();                //Deseleccionamos todos
            listViewSongs.Items[s].Selected = true;             //seleccionamos en el nuevo index
            listViewSongs.Items[s].Focused = true;
            getListMetadata(s);                                 //Mandamos los metadatos.
        }

        private void getListMetadata(int ind)
        {
            //Se agregan los datos de la cancion seleccionada a los cuados de texto
            textArtist.Text = listSong[ind].Artist;
            textAlbum.Text = listSong[ind].Album;
            textGenre.Text = listSong[ind].Genre;
            textYear.Text = (listSong[ind].Year).ToString();
        }

        private void listViewSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Funcion que controla los clics en la lista
            try
            {
                int s = listViewSongs.SelectedItems[0].Index;
                getListMetadata(s);
            }
            catch(Exception ex)
            {
                Console.WriteLine("{0} Exception!", ex);
            }
        }
    }
}
