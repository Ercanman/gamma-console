using gamma_console.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace gamma_console.Client
{
    public class MemberClient
    {

        public List<Member> GetTeamMember(string teamName)
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://app-lab-codingdojo-alpha.azurewebsites.net")
            };
            HttpResponseMessage response = client.GetAsync("Member/GetMembersByTeam/" + teamName).Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;
           
            List<Member> teamMembers = JsonConvert.DeserializeObject<List<Member>>(responseBody);

            return teamMembers;
        }

        public MemberWithFavoriteMovies GetMember(Guid id)
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri("https://app-lab-codingdojo-alpha.azurewebsites.net")
            };
            HttpResponseMessage response = client.GetAsync("Member/GetMemberById/" + id).Result;
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(responseBody);

            //resonseBody innehåller alla personer
            MemberWithFavoriteMovies? memberWithFav = JsonConvert.DeserializeObject<MemberWithFavoriteMovies>(responseBody);

            return memberWithFav;
        }
    }
}
