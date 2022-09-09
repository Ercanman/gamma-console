using gamma_console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamma_console.Service
{
    internal class MemberService
    {
        public List<Member> GetMemberNamesByTeam(string teamName)
        {
            //var client = new MemberClient();
            //var teamMembers = client.GetMembersByTeam(teamName);
            return new List<Member>
            {
                new Member{Id = new Guid(), FullName = "Adam", Team = "Gamma"},
                new Member{Id = new Guid(), FullName = "Olof", Team = "Alpha"}
            };
        }

        public MemberWithFavoriteMovies GetMemberById(Guid id)
        {
            //var client = new MemberClient();
            //var memberDetails = client.GetMemberDetails(id);
            //return memberDetails;
            return new MemberWithFavoriteMovies
            {
                Id = new Guid(),
                FullName = "Adam",
                Team = "Gamma",
                FavoriteMovies = new List<Movie>
                {
                    new Movie
                    {
                        Id = "tt04568",
                        Title = "Fargo",
                        Year = 1997,
                        RuntimeMinutes = 165,
                        Genres = new List<string>
                        {
                            "Drama",
                            "Action"
                        }
                    }
                }
            };
        }
    }
}
