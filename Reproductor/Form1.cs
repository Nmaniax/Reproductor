using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reproductor
{
    public partial class Form1 : Form
    {
        List<Songs> listSong = new List<Songs>();
        ReproductionCtrl reproduction = new ReproductionCtrl();

        public Form1()
        {
            InitializeComponent();
            lvSetup();
            createSongs();
            showSongs();
            listViewSongs.Items[0].Selected = true;
        }
        

        private void lvSetup()
        {
            //Activamos la vista por columnas y se agregan las dos columnas en sus respectivas posiciones
            listViewSongs.View = View.Details;
            listViewSongs.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listViewSongs.Columns.Add("Duration", -2, HorizontalAlignment.Left);
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

        private void clearMetadata()
        {
            //Se limpian las casillas de texto
            textArtist.Text = "";
            textAlbum.Text = "";
            textGenre.Text = "";
            textYear.Text = "";
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
        /// <summary>
        /// Esta funcion se encarga de cargar las canciones elegidas del explorador a la lista de canciones
        /// </summary>
        /// <param name="sng"> Es la lista de rutas de canciones encontradas al momento de la carca,
        /// posteriormente será utilizada para conseguir los metadatos de cada mp3</param>
        private void getSongsFiles(String[] sng)
        {
            
            listSong.Clear();
            listViewSongs.Items.Clear();
            foreach(var s in sng)
            {
                Songs song = new Songs();
                song.extractData(s);
                listSong.Add(song);
            }
        }
        /// <summary>
        /// funcion que se encarga de activar los botones de reproduccion de mp3
        /// </summary>
        private void enableReproduction()
        {
            btnPlay.Enabled = true;
            btnPlay.Visible = true;
            btnPause.Enabled = true;
            btnPause.Visible = true;
            btnStop.Enabled = true;
            btnStop.Visible = true;
        }
        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowNewFolderButton = true;
            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
               //Se busca las rutas de archivos .mp3 y se guardan en una lista de Strings
                var path = folderBrowser.SelectedPath;
                String[] songs = Directory.GetFiles(path, "*.mp3");

                if(songs.Length > 0)
                {
                    //Se agregan las canciones a la lista
                    // se limpia la pantalla de metadata y se muestran la nueva lista.
                    getSongsFiles(songs);
                    clearMetadata();
                    showSongs();
                    enableReproduction();
                }
                else
                {
                    //Se presenta un cuadro de error si la busqueda no devuelve nada
                    String mess = "No mp3 files found";
                    String caption = "No songs found";

                    MessageBoxButtons btn = MessageBoxButtons.OK;
                    DialogResult alert;
                    alert = MessageBox.Show(mess, caption, btn);
                }
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            if (listViewSongs.SelectedItems.Count == 0)
                return;

            int s = listViewSongs.SelectedItems[0].Index;
            
            reproduction.playAction(listSong[s].Path);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count == 0)
                return;
            reproduction.stopAction();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count == 0)
                return;
            reproduction.pauseAction();
        }
    }
}
