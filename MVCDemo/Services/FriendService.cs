using MVCDemo.Controllers;
using MVCDemo.Models;
using System.Xml.Linq;

namespace MVCDemo.Services
{
    public class FriendService
    {
       
            static List<Friend> Friends { get; }
            static int nextId = 3;
            static FriendService()
            {
                Friends = new List<Friend>
                {
                    new Friend { FriendId = 1,FriendName = "Kiran", Place="Kottur" },
                    new Friend { FriendId = 2, FriendName = "Vinay", Place="Dinni" }
                };
            }

        public static List<Friend> GetAll() => Friends;

            public static Friend? Get(int id) => Friends.FirstOrDefault(p => p.FriendId == id);

            public static void Add(Friend friend)
            {
                friend.FriendId = nextId++;
                Friends.Add(friend);
            }

            public static void Delete(int id)
            {
                var friend = Get(id);
                if (friend is null)
                    return;

                Friends.Remove(friend);
            }

            public static void Update(Friend friend)
            {
                var index = Friends.FindIndex(p => p.FriendId == friend.FriendId);
                if (index == -1)
                    return;

                Friends[index] = friend;
            }

            internal static Friend Get()
            {
                throw new NotImplementedException();
            }

            internal static Friend Update(int id)
            {
                throw new NotImplementedException();
            }
        }


    }

