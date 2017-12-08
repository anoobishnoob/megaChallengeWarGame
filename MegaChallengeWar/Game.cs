using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MegaChallengeWar
{
    public class Game
    {
        private Player _player1;
        private Player _player2;
       

        public Game(string player1Name, string player2Name)
        {
            _player1 = new Player() { Name = player1Name };
            _player2 = new Player() { Name = player2Name };
            
            //Deck deck = new Deck();

        
        }
        public string Play()
        {
            Deck deck = new Deck();

            string result = "<h3>Dealing cards... </h3>";
            result += deck.Deal(_player1, _player2);

            result += "<h3>Begin Battle... </h3>";
            int round = 0;
            while (_player1.Cards.Count != 0 && _player2.Cards.Count != 0)
            {

                Battle battle = new Battle();
                result += battle.performBattle(_player1, _player2);

                round++;
                if (round > 20)
                    break;

            }
            // determine the winner
            result += determineWinner();
            return result;
        }
        
       // private List<Card> _bounty;
        private string determineWinner()
        {
            string result = "";
            if (_player1.Cards.Count > _player2.Cards.Count)
                result += "<br/><span style='color:red;font-weight:bolder;'>Player 1 wins!</span>";
            else if (_player2.Cards.Count > _player1.Cards.Count)
                result += "<br/><span style='color:blue;font-weight:bolder;'> Player 2 wins!</span>";
            else
                result += "<br/><span style='font-weight:bolder;'> Game is a draw!</span>";
                // noticed that I had a draw, and player 2 won, so I expanded the logic

            result += "<br/><span style='color:red;font-weight:bolder;'> Player1:" + _player1.Cards.Count + "</span> <br/><span style='color:blue;font-weight:bolder;'>Player2: "+ _player2.Cards.Count +"</span>";
            return result;
        }

    }
}