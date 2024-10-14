
using LeetCode.Solutions.Shared;

namespace LeetCode.Solutions;

internal class Solution0355 : IRunProgram
{
    public void Run()
    {
        var twitter = new Twitter();
        twitter.PostTweet(1, 5);
        twitter.GetNewsFeed(1).Print();
        twitter.Follow(1, 2);
        twitter.PostTweet(2, 6);
        twitter.PostTweet(2, 8);
        twitter.GetNewsFeed(1).Print();
    }
    public class Twitter
    {
        private Dictionary<int, User> users = new Dictionary<int, User>();
        private int tick = 0;
        public Twitter() { }

        public void PostTweet(int userId, int tweetId)
        {
            if (!users.ContainsKey(userId)) users.Add(userId, new User(userId));
            users[userId].AddTweet(tweetId, tick++);
        }

        public IList<int> GetNewsFeed(int userId)
        {
            if (!users.ContainsKey(userId)) return [];
            var queue = new PriorityQueue<(int, int), int>();
            foreach (var follow in users[userId].GetFollowing())
            {
                var tweets = users[follow].GetTweets();
                foreach ((var id, var tick) in tweets)
                {
                    queue.Enqueue((id, tick), tick);
                    if (queue.Count > 10)
                    {
                        queue.Dequeue();
                        if (queue.Peek().Item2 >= tick) break;
                    }
                }
            }
            foreach ((var id, var tick) in users[userId].GetTweets())
            {
                queue.Enqueue((id, tick), tick);
                if (queue.Count > 10)
                {
                    queue.Dequeue();
                    if (queue.Peek().Item2 >= tick) break;
                }
            }
            var output = new List<int>();
            while (queue.Count > 0)
                output.Insert(0, queue.Dequeue().Item1);

            return output;
        }

        public void Follow(int followerId, int followeeId)
        {
            if (!users.ContainsKey(followerId)) users.Add(followerId, new User(followerId));
            if (!users.ContainsKey(followeeId)) users.Add(followeeId, new User(followeeId));
            users[followerId].following.Add(followeeId);
        }

        public void Unfollow(int followerId, int followeeId)
        {
            if (users.ContainsKey(followerId)) users[followerId].following.Remove(followeeId);
        }
    }

    class User
    {
        public int user_id = 0;
        public HashSet<int> following = new HashSet<int>();
        public Queue<(int, int)> tweets = new Queue<(int, int)>(10);

        public User(int id) => user_id = id;

        public void AddTweet(int id, int tick)
        {
            if (tweets.Count >= 10)
                tweets.Dequeue();

            tweets.Enqueue((id, tick));
        }

        public IEnumerable<int> GetFollowing()
        {
            foreach (var follow in following) yield return follow;
        }

        public List<(int, int)> GetTweets() => tweets.Reverse().ToList();

        public override bool Equals(object? obj) => obj is User user && user_id == user.user_id;
        public override int GetHashCode() => HashCode.Combine(user_id);
    }
}
