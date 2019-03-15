using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor
{
    class ReproductionCtrl
    {
        /// <summary>
        /// Se crea una clase que sea el controlador principal de la reproduccion
        /// </summary>
       
        AxWMPLib.AxWindowsMediaPlayer player;
        String songStarted; //bandera, detecta cuando ya se inicia una cancion
       
        public ReproductionCtrl()
        {
            songStarted = "";
            player = new AxWMPLib.AxWindowsMediaPlayer();
            player.CreateControl();

        }
        /// <summary>
        /// Se envia una ruta del archivo a reproducir si la ruta esta vacia o es la misma ruta que la anterior
        /// no se hace nada
        /// Si es diferente ruta se reproduce el nuevo archivo
        /// se asume que anteriormente ya se comprobo la existencia del archivo
        /// </summary>
        /// <param String="path"> Esta variable envia la ruta que fue tomada directamente de la cancion desde la lista de canciones
        /// se encarga</param>
        /// 
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
