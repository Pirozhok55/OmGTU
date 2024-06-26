import collections
def bfs(graph, root): 
    visited, queue = set(), collections.deque([root])
    visited.add(root)
    while queue: 
        vertex = queue.popleft()
        for neighbour in graph[vertex]: 
            if neighbour not in visited: 
                visited.add(neighbour) 
                queue.append(neighbour) 
graph = {0: [1, 2], 1: [3, 4], 2: [3], 3: [1,2]} 
breadth_first_search(graph, 0)
