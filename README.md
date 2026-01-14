The purpose of this README file is just to address and discuss a few trade-offs and assumptions that I made for this particular exercise.
Even though it is a pretty simple and straightforward solution, there are a few decisions/assumptions worth mentioning:

1. I chose a floating-point type instead of integers, because space didn't seem to be a constraint and it seemed reasonable to assume that users would like to add fractional numbers. In this case, `double` is more precise than `float`, hence the choice.

2. I also assumed users would like to add both negative and positive numbers, so no verification was added to make sure numbers are only positive, for example.

3. There are a few different ways the class itself can be implemented. My first approach was to store all the numbers in a `List<double>`, but I realized that, given the requirements, storing the added numbers wasn't requested. For this reason, I switched from the List approach to a simpler approach where the class stores only the sum of all added values. The main reason for that was performance. Even though keeping track of all added numbers in a list would allow you in the future to perform other operations like median or even delete/remove values from the average, it is O(n) space and extracting the average requires iterating over the whole collection (O(n) again). The implemented version, on the other hand, is O(1) for both operations (division and adding new values).

4. I created two methods for number addition. Users can either add one number or multiple ones at a time. It is also possible to add one number using the AddNumbers method, but it would lead to some awkwardness, because it would require the implementer to write something like `AddNumbers(new[] { 5.0 })`.

5. Mathematically, the average of nothing is undefined. It could return 0, but I thought it would be misleading. Hence the exception thrown.

6. Finally, the Program class doens't expect any user's input via CLI, so it will only output the average of the hardcoded values. In future iterations, the program could expect some custom input from users, but for this first implementation, I judged it an overreach.

The project was built by running:

```bash
dotnet new console --lang C#
```

Which means you can run it locally with (as long as you have dotnet SDK installed):

```bash
dotnet run
```
