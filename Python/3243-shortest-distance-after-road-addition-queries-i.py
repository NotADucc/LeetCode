class Solution:
    def shortestDistanceAfterQueries(self, n: int, queries: List[List[int]]) -> List[int]:
        SOURCE, DEST = 0, n - 1
        adj_list = []
        bfs_mem = [0]
        for i in range(n - 1):
            adj_list.append([i + 1])
            bfs_mem.append(n + 1)

        answer = []
        for (u, v) in queries:
            adj_list[u].append(v)
            # BFS
            # make use of a mem, only update after 'u' since only the values after that index change and before stays the same
            queue = collections.deque([0 if bfs_mem[-1] == n + 1 else u]) 
            visited = [False] * n
            while True:
                node = queue.popleft()
                if node == DEST:
                    answer.append(bfs_mem[-1])
                    break

                for neighbor in adj_list[node]:
                    # i thought min() would be ok here but it's expensive as heck
                    if bfs_mem[node] + 1 < bfs_mem[neighbor] :
                        bfs_mem[neighbor] = bfs_mem[node] + 1
                    if not visited[neighbor] :
                        visited[neighbor] = True
                        queue.append(neighbor)
            
            if answer[-1] == 1:
                return answer + [1] * (len(queries) - len(answer))

        return answer