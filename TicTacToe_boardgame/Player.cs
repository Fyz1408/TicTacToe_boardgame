using System.Collections.Generic;

namespace TicTacToe_boardgame
{
    public class Player
    {
        public string PlayerName;

        public Token.TokenType PlayerType;

        public Player(string name, Token.TokenType type )
        {
            PlayerName = name;
            PlayerType = type;
            
        }
        
    }
}