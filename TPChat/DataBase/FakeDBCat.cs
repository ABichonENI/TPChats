using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TPChat.Models;

namespace TPChat.DataBase
{
    
    public sealed class FakeDBCat
    {
        private FakeDBCat()
        {
            this.Chats = this.GetMeuteDeChats();
        }
        private static readonly object padlock = new object();
        private static FakeDBCat instance = null;
        public static FakeDBCat Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new FakeDBCat();
                    }
                    return instance;
                }
            }
        }

        public List <Chat> Chats { get; set; }

        private List<Chat> GetMeuteDeChats()
        {
            var i = 1;
            return new List<Chat>
            {
                new Chat{Id=i++,Nom = "Felix",Age = 3,Couleur = "Roux"},
                new Chat{Id=i++,Nom = "Minette",Age = 1,Couleur = "Noire"},
                new Chat{Id=i++,Nom = "Miss",Age = 10,Couleur = "Blanche"},
                new Chat{Id=i++,Nom = "Garfield",Age = 6,Couleur = "Gris"},
                new Chat{Id=i++,Nom = "Chatran",Age = 4,Couleur = "Fauve"},
                new Chat{Id=i++,Nom = "Minou",Age = 2,Couleur = "Blanc"},
                new Chat{Id=i,Nom = "Bichette",Age = 12,Couleur = "Rousse"}
            };
        }
    }

}
