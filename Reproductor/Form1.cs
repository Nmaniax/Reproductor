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
            listViewSongs.View = View.Details;
            listViewSongs.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listViewSongs.Columns.Add("Duration", -2, HorizontalAlignment.Left);
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count == 0)
                return;
            listViewSongs.Focus();

            int s = listViewSongs.SelectedItems[0].Index;

            listViewSongs.Items[s].Selected = false;
            listViewSongs.SelectedItems.Clear();
            listViewSongs.Items[0].Selected = true;
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

            s = listSong.Count -1;
            listViewSongs.Items[s].Selected = true;
            listViewSongs.Items[s].Focused = true;
            getListMetadata(s);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count == 0)
                return;
            listViewSongs.Focus();

            int s = listViewSongs.SelectedItems[0].Index;

            listViewSongs.Items[s].Selected = false;

            if (s > 0)
                s--;
            listViewSongs.SelectedItems.Clear();
            listViewSongs.Items[s].Selected = true;
            listViewSongs.Items[s].Focused = true;
            getListMetadata(s);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count == 0)
                return;
            listViewSongs.Focus();

            int s = listViewSongs.SelectedItems[0].Index;

            listViewSongs.Items[s].Selected = false;

            if (s < listViewSongs.Items.Count - 1)
                s++;
            listViewSongs.SelectedItems.Clear();
            listViewSongs.Items[s].Selected = true;
            listViewSongs.Items[s].Focused = true;
            getListMetadata(s);
        }

        private void getListMetadata(int ind)
        {
            textArtist.Text = listSong[ind].Artist;
            textAlbum.Text = listSong[ind].Album;
            textGenre.Text = listSong[ind].Genre;
            textYear.Text = (listSong[ind].Year).ToString();
        }

        private void listViewSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
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
