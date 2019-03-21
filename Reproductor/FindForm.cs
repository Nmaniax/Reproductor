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
    public partial class FindForm : Form
    {
        List<Songs> listSong;
        public FindForm(List<Songs> list)
        {
            InitializeComponent();
            listSong = new List<Songs>(list);
            lvSetup();
        }

        private void lvSetup()
        {
            //Activamos la vista por columnas y se agregan las dos columnas en sus respectivas posiciones
            listViewSong1.View = View.Details;
            listViewSong1.Columns.Add("Name", -2, HorizontalAlignment.Left);
            listViewSong1.Columns.Add("Duration", -2, HorizontalAlignment.Left);
            showSongs(listSong);
        }

        private void showSongs(List<Songs> list)
        {
            //En esta funcion se agregan canciones a el objecto ListView
            ListViewItem itm;
            String[] str = new String[2];
            foreach (Songs s in list)
            {
                str[0] = s.Name;
                str[1] = s.Duration;
                itm = new ListViewItem(str);
                listViewSong1.Items.Add(itm);
            }
        }

        private void listViewSong1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if( txtArtist.Text != "" )
            {
                List<Songs> list = (from s in listSong
                           where s.Artist == txtArtist.Text
                           select s).ToList();
                listViewSong1.Items.Clear();
                showSongs(list);

            }
        }

        private void txtArtist_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
