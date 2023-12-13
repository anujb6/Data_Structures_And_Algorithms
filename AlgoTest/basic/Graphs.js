const graph = {
    a: ['c', 'b'],
    b: ['d'],
    c: ['e'],
    d: ['f'],
    e: [],
    f: []
}

// a ---> c
// |      |
// b      e
// |
// d ---> f

function buildAdjacencyList(edges) {
    const adjList = {};
    for (let edge of edges) {
        const [a, b] = edge;
        if (!(a in adjList)) adjList[a] = [];
        if (!(b in adjList)) adjList[b] = [];
        adjList[a].push(b);
        adjList[b].push(a);
    }
    return adjList;
}

/**
 * Depth First Traversal
 * Expected output = abdfce
**/

const depthFirstTraversal = (graph, source) => {
    const stack = [source]
    while(stack.length > 0){
        const current = stack.pop()
        console.log(current)
        
        for(let neighbour of graph[current]){
            stack.push(neighbour)
        }
    } 
}

depthFirstTraversal(graph, 'a')

/**
 * Breadth First Traversal
 * Expected output = acbedf
**/

const breadthFirstTraversal = (graph, source) => {
    const queue = [source]
    while(queue.length > 0){
        const current = queue.pop()
        console.log(current)
        
        for(let neighbour of graph[current]){
            queue.unshift(neighbour)
        }
    }
}
breadthFirstTraversal(graph, 'a')
