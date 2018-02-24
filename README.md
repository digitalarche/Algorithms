# Algorithms

* More will be added soon.

## Merge Sort

- A recursive approach to sort an array, complexity is always `O(nlog(n))`.
- Splitting the problem always to smaller problem and solving it at the end.
- When building the array back we take the current two arrays we broke at recursion, we iterate on them together and we insert the values in such a way that if the smaller value from the arrays will be inserted in the returned array.

## Quick Sort

- Can be done in-place ( using swaps ), doesn't require an additional buffer.
- Select a random item `p` from the items we want to sort, and split the remaining `n-1` items to two groups, those that are above `p` and below `p`. Now sort each group in itself. This leaves `p` in its exact place in the sorted array.
- Partitioning the remaining `n-1` items is linear.
- If we pick the median element as the pivot in each step, `h = log(n)`; this is the best case of quicksort.
- If we pick the left- or right-most element as the pivotal element each time (biggest or smallest value), `h = n` (worst case).
- On average quicksort will produce good pivots and have `nlog(n)`.
- If we are most unlucky, and select the extreme values, quicksort becomes selection sort and runs `O(n^2)`.

## BFS

- Breadth-first search in an algorithm which finds the shortest path by vertices from start vertice to the end of graph.
- Time and space complexity will be: Let's say `|V|` is size of vertices, and `|E|` is the size of edges, We'll express the complexity with `O(|V| + |E|)`.

## DFS

- Starts exploring the graph from the root, but immediately expanding as far as possible.
- Time and space complexity will be: Let's say `|V|` is size of vertices, and `|E|` is the size of edges, We'll express the complexity with `O(|V| + |E|)`.