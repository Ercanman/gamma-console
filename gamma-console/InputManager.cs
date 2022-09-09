using gamma_console.Models;
using gamma_console.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gamma_console
{
    internal class InputManager
    {
        public void GetInput()
        {
            Console.Write("Write team name: ");
            var teamName = Console.ReadLine();

            var memberService = new MemberService();

            var members = memberService.GetMemberNamesByTeam(teamName);

            PrintTeamMembers(members);
            
            var memberIndex = GetMemberIndex(members.Count);

            var member = members[memberIndex];

            MemberWithFavoriteMovies memberWithFavorite = memberService.GetMemberById(member.Id);

            PrintMemberDetails(memberWithFavorite);
            PrintFavoriteMovies(memberWithFavorite);
        }

        private void PrintTeamMembers(List<Member> members)
        {
            for (int i = 0; i < members.Count; i++)
                Console.WriteLine((i + 1) + " " + members[i].FullName);
        }

        private int GetMemberIndex(int memberCount)
        {
            int memberIndex;
            do
            {
                Console.Write("Select a member: ");

            } while (!int.TryParse(Console.ReadLine(), out memberIndex) ||
                     memberIndex - 1 < 0 ||
                     memberIndex - 1 > memberCount - 1);
            
            return memberIndex - 1;
        }

        private void PrintMemberDetails(MemberWithFavoriteMovies member)
        {
            var memberDetails = string.Format("Id: {0}\nName: {1}\nTeam: {2}\n",
                                        member.Id,
                                        member.FullName,
                                        member.Team);

            Console.WriteLine("---MEMBER DETAILS---");
            Console.WriteLine(memberDetails);
        }

        private void PrintFavoriteMovies(MemberWithFavoriteMovies member)
        {
            Console.WriteLine("---FAVORITE MOVIES---");

            foreach (var movie in member.FavoriteMovies)
            {
                var movieDetails = string.Format("Id: {0}\nTitle: {1}\nYear: {2}\nRuntimeMinutes: {3}\nGenres: ",
                                                 movie.Id,
                                                 movie.Title,
                                                 movie.Year,
                                                 movie.RuntimeMinutes);

                Console.Write(movieDetails);

                foreach (var genre in movie.Genres)
                {
                    Console.Write(genre + " ");
                }

                Console.WriteLine();
            }
        }
        
    }
}
