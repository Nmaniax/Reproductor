using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor
{
    class ReproductionCtrl
    {
        AxWMPLib.AxWindowsMediaPlayer player;
        String songStarted; //bandera, detecta cuando ya se inicia una cancion

        public ReproductionCtrl()
        {
            songStarted = "";
            player = new AxWMPLib.AxWindowsMediaPlayer();
            player.CreateControl();

        }

        public void playAction(String path)
        {
            if (path != "" && songStarted != path)
            {
                player.URL = path;
                player.Ctlcontrols.play();
                songStarted = path;
            }
            else if(songStarted != "")
            {
                player.Ctlcontrols.play();
            }
        }

        public void pauseAction()
        {
            player.Ctlcontrols.pause();
        }
        public void stopAction()
        {
            player.Ctlcontrols.stop();
        }
    }
}
