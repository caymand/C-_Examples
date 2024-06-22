Short implementation of [Casey Muratori's take on Clean Code Horrible performance](https://www.computerenhance.com/p/clean-code-horrible-performance) in C#.

Also see: https://godbolt.org/z/sh9nr1GGo 

Initial results:

Virtual. Time for 1: 3\
Virtual. Time for 100: 168\
Inlined. Time for 1: 2\
Inlined. Time for 100: 108

And a bit later:

Virtual. Time for 1: 8\
Virtual. Time for 100: 602\
Inlined. Time for 1: 2\
Inlined. Time for 100: 69