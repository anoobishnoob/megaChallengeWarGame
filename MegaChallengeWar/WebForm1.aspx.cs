using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeWar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void playButton_Click(object sender, EventArgs e)
        {
            /* Deck deck = new Deck(); for testing my deck list
             foreach (var card in deck._deck)
             {
                 resultLabel.Text += "<br/>" + card.Suit + " " + card.Kind;
             } */
            Game game = new Game("Player1", "Player2");
            resultLabel.Text = game.Play();

        }
    }
}