public class Twitter {

    Dictionary<int, List<int[]>> tweets;
    Dictionary<int,HashSet<int>> follows;
    int time;

    public Twitter() {
        tweets = new Dictionary<int, List<int[]>>();
        follows = new Dictionary<int, HashSet<int>>();
        time = 0;
        
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!tweets.ContainsKey(userId))
        {
            tweets[userId] = new List<int[]>();
        }
        tweets[userId].Add(new int[] {time++, tweetId});

        
    }
    
    public List<int> GetNewsFeed(int userId) {
        List<int> res = new List<int>();
        PriorityQueue<int[], int> min = new PriorityQueue<int[], int>();
        if(!follows.ContainsKey(userId))
        {
        follows[userId] = new HashSet<int>();
        }
        follows[userId].Add(userId);

       foreach (int followeeId in follows[userId]) {
            if (tweets.ContainsKey(followeeId) && tweets[followeeId].Count > 0) {
                List<int[]> tweet = tweets[followeeId];
                int index = tweet.Count - 1;
                int[] latestTweet = tweet[index];
                min.Enqueue(new int[] { latestTweet[0], latestTweet[1], followeeId, index }, -latestTweet[0]);
            }
        }

        while (min.Count > 0 && res.Count < 10) {
            int[] curr = min.Dequeue();
            res.Add(curr[1]);
            int index = curr[3];
            if (index > 0) {
                int[] tweet = tweets[curr[2]][index - 1];
                min.Enqueue(new int[] { tweet[0], tweet[1], curr[2], index - 1 }, -tweet[0]);
            }
        }

        return res;
        
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!follows.ContainsKey(followerId))
        {
            follows[followerId] = new HashSet<int>{followeeId};
        }
        follows[followerId].Add(followeeId);

        
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if(follows.ContainsKey(followerId))
        {
            follows[followerId].Remove(followeeId);
        }
        
    }
}
