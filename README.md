# LazyList
Lazy implementation of List<T> that will automatically instantiate  missing elements.

##How to use
    List<string> list = new List<string>();
    list.Add("Hello World");
    string s = list[5];
  
Normally, the code above would immediately result in a runtime error because there is only a single item in "list".

LazyList gets around this by silently instantiating the missing elements.
    LazyList<string> list = new LazyList<string>();
    list.Add("I'm Lazy!");
    string s = list[5];

Viola!  No more runtime error.
  
