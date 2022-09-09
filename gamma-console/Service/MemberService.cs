using gamma_console.Client;
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
            var client = new MemberClient();
            var teamMembers = client.GetTeamMember(teamName);
            return teamMembers;
        }

        public MemberWithFavoriteMovies GetMemberById(Guid id)
        {
            var client = new MemberClient();
            var memberDetails = client.GetMember(id);
            return memberDetails;
        }
    }
}
