using ClassLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MovieLibrary
{
    public class TableManager
    {
        public CountryTable countryTable { get;}
        public ActorTable actorTable { get; }
        public DirectorTable directorTable { get; }
        public CommentTable commentTable { get; }
        public FilmTable filmTable { get; }
        public Films_ActorsTable filmsActorsTable { get; }
        public GenreTable genreTable { get; }
        public UserTable userTable { get; }
        public RolesTable rolesTable { get; }
        public ModelProvider modelProvider { get; }
        private TableManager()
        {
            countryTable = new CountryTable("Countries");
            actorTable = new ActorTable("Actors");
            commentTable = new CommentTable("Comments");
            filmTable = new FilmTable("Films");
            filmsActorsTable = new Films_ActorsTable("Films_Actors");
            genreTable = new GenreTable("Generes");
            userTable = new UserTable("Users");
            rolesTable = new RolesTable("Access");
            directorTable = new DirectorTable("Directors");
            modelProvider = new ModelProvider();

        }

        private static TableManager obj;
        public static TableManager GetManager()
        {
            if (obj == null) obj = new TableManager();
            return obj;
        }
    }
}
